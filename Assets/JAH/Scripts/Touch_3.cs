using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_3 : MonoBehaviour
{
    // - 캐릭터1
    public GameObject character_1;
    // - 캐릭터2
    public GameObject character_2;
    // - 캐릭터4
    public GameObject character_4;


    // 역할 1 : Character_1(나 자신)을 터치하면 나 자신만 활성화
    public void Touch()
    {
        // 터치하지 않으면 반응X
        if (Input.touchCount == 0) return;

        // 첫 번째 터치 정보 불러오기
        Touch touch = Input.GetTouch(0);

        // Choose img_1(나 자신)을 터치하면 캐릭릭터3 만 활성화
        if (touch.phase == TouchPhase.Began)
        {
            // if(캐릭터 1만 터치하면)
            // - 나머지 비활성화
            Destroy(character_1);
            Destroy(character_2);
            Destroy(character_4);

        }
    }
}
