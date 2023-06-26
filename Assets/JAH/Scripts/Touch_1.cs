using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 역할 1 : Character_1(나 자신)을 터치하면 나 자신만 활성화
// - 캐릭터2,3 비활성화

// 역할 2 : 2초 후 Scene(커스텀하는)전환

public class Touch_1 : MonoBehaviour
{
    // - 캐릭터2
    public GameObject character_2;
    // - 캐릭터3
    public GameObject character_3;


    // 역할 1 : Character_1(나 자신)을 터치하면 나 자신만 활성화
    // - 캐릭터2,3 비활성화
    public void Touch()
    {
        // 터치하지 않으면 반응X
        if (Input.touchCount == 0) return;

        // 첫 번째 터치 정보 불러오기
        Touch touch = Input.GetTouch(0);

        // Choose img_1(나 자신)을 터치하면 캐릭릭터1 만 활성화
        if (touch.phase == TouchPhase.Began)
        {
            // - 캐릭터2,3 비활성화
            character_2.gameObject.SetActive(false);
            character_3.gameObject.SetActive(false);

            // 3초 후 커스텀하는 Scene으로 전환
            StartCoroutine(CustomScene());
        }
    }

    IEnumerator CustomScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("CustomScene");
    }
}
