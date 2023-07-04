using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

// 역할 1 : 이름을 입력하고 엔터를 누르면 커스텀 UI 제거
// - 커스텀 UI

// 역할 2:  카메라 UI 생성
// - 카메라 UI

// 역할 3 : Midair인식기를 지운다
// - Midair인식

// 역할 4 : 저장 버튼을 생성
// - 저장버튼
public class NameEnter : MonoBehaviour
{
    // - 커스텀 UI
    public GameObject customUI;
    // - 카메라 On 버튼
    public GameObject OnBtn;
    // - 카메라 Background 버튼
    //public GameManager
    // - Midair인식
    public GameObject midairFinder;


    public void NameInput()
    {
        // 역할 1 : 이름을 입력하고 엔터를 누르면 커스텀 UI 제거
        customUI.SetActive(false);

        // 역할 2:  카메라 UI 생성
        OnBtn.gameObject.SetActive(true);

        // 역할 3 : Midair인식기를 지운다
        // Plan Finder의 앵커스테이지에서 Ground Plan Stage 제거
        MidAirPositionerBehaviour.Destroy(midairFinder);

    }
}
