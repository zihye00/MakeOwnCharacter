using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGuide : MonoBehaviour
{
    public GameObject cameraui;
    private bool isActive;

    public void CameraGuideUI()
    {
        if (isActive) return;

        StartCoroutine(CameraUI());
        Debug.Log("카메라가이드");
    }

    IEnumerator CameraUI()
    {
        BGMManager.Instance.OnStartCameraMusic();
        isActive = true;
        cameraui.SetActive(true);
        yield return new WaitForSeconds(2);
        cameraui.SetActive(false);

    }


}
