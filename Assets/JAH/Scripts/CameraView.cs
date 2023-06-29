using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class CameraView : MonoBehaviour
{
    // 스마트폰 카메라 영상 받아오는 api
    WebCamTexture camTexture;

    // 카메라 화면
    public RawImage cameraViewImage;

    // 카메라 모드
    public void CameraOn()
    {
        // 카메라 권한 확인
        if(!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }

        // 카메라가 없다면...
        if(WebCamTexture.devices.Length == 0)
        {
            print("카메라 없음");
            return;
        }

        // 스마트폰의 카메라 정보를 모두 가져온다
        WebCamDevice[] devices = WebCamTexture.devices;
        int selectedCameraIdex = -1;

        // 셀카 모드 카메라 찾기
        for (int i = 0;  i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing == true)
            {
                selectedCameraIdex = i;
                break;
            
        }
        }

        // 카메라 켜기
        if(selectedCameraIdex >= 0)
        {
            // 선택된 셀카모드 카메라를 가져옴
            camTexture = new WebCamTexture(devices[selectedCameraIdex].name, Screen.width, Screen.height);

            // 카메라 프레임 설정
            camTexture.requestedFPS = 30;

            // 영상을 raw Image에 할당
            cameraViewImage.texture = camTexture;

            // 카메라 시작
            camTexture.Play();
        }
    }

    // 카메라 끄기 
    public void CameraOff()
    {
        if(camTexture != null)
        {
            // 카메라 정지
            camTexture.Stop();
            // 카메라 객체 반납
            WebCamTexture.Destroy(camTexture);
            // 카메라 api 초기화
            camTexture = null;
        }
    }
}
