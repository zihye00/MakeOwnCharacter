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
        Debug.Log("ī�޶��̵�");
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
