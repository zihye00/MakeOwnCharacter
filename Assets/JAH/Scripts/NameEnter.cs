using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 역할 1 : 이름을 입력하고 엔터를 누르면 커스텀 UI 제거
// - 커스텀 UI
// 역할 2:  카메라 UI 생성
// - 카메라 UI

public class NameEnter : MonoBehaviour
{
    // - 커스텀 UI
    public GameObject customUI;
    // - 카메라 UI
    public GameObject cameraUI;

    public void NameInput()
    {
        // 역할 1 : 이름을 입력하고 엔터를 누르면 커스텀 UI 제거
        Destroy(customUI);
        // 역할 2:  카메라 UI 생성
        cameraUI.gameObject.SetActive(true);
    }
}
