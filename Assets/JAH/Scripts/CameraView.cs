using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class CameraView : MonoBehaviour
{
    // ����Ʈ�� ī�޶� ���� �޾ƿ��� api
    WebCamTexture camTexture;

    // ī�޶� ȭ��
    public RawImage cameraViewImage;

    // ī�޶� ���
    public void CameraOn()
    {
        // ī�޶� ���� Ȯ��
        if(!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }

        // ī�޶� ���ٸ�...
        if(WebCamTexture.devices.Length == 0)
        {
            print("ī�޶� ����");
            return;
        }

        // ����Ʈ���� ī�޶� ������ ��� �����´�
        WebCamDevice[] devices = WebCamTexture.devices;
        int selectedCameraIdex = -1;

        // ��ī ��� ī�޶� ã��
        for (int i = 0;  i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing == true)
            {
                selectedCameraIdex = i;
                break;
            
        }
        }

        // ī�޶� �ѱ�
        if(selectedCameraIdex >= 0)
        {
            // ���õ� ��ī��� ī�޶� ������
            camTexture = new WebCamTexture(devices[selectedCameraIdex].name, Screen.width, Screen.height);

            // ī�޶� ������ ����
            camTexture.requestedFPS = 30;

            // ������ raw Image�� �Ҵ�
            cameraViewImage.texture = camTexture;

            // ī�޶� ����
            camTexture.Play();
        }
    }

    // ī�޶� ���� 
    public void CameraOff()
    {
        if(camTexture != null)
        {
            // ī�޶� ����
            camTexture.Stop();
            // ī�޶� ��ü �ݳ�
            WebCamTexture.Destroy(camTexture);
            // ī�޶� api �ʱ�ȭ
            camTexture = null;
        }
    }
}
