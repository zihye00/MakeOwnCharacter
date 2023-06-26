using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 역할: 바닥을 인식 OR 인식하지 못했을 때 발생하는 Event를 관리

// - 바닥이 인식 되었을 때
//   > 캐릭터 4명(나 자신)을 띄운다

// - 바닥이 인식되지 못했을 때
//   > 캐릭터 4명을 띄우지X

public class Characters : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }
    // - 바닥이 인식 되었을 때
    public void OnPlaneFound()
    {
        print("바닥 인식");
        //   > 캐릭터 4명(나 자신)을 띄운다
        gameObject.SetActive(true);
    }

    // - 바닥이 인식되지 못했을 때
    public void OnPlanLost()
    {
        print("바닥 인식X");
        //   > 캐릭터 4명을 띄우지X
        gameObject.SetActive(false);

    }
}
