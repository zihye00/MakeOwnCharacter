using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

// 역할  : 캐릭터을 터치하면 나 자신만 활성화
// - 나머지 캐릭터들 비활성화


public class TouchManager : MonoBehaviour
{

    // - 나머지 캐릭터들
    public GameObject[] characters;
    // - 커스텀 UI
    public GameObject customUI;
    public Camera cam;
    public GameObject planFinder;

    private void Update()
    {
        Touch();
    }
    // 역할 1 : Character_1(나 자신)을 터치하면 나 자신만 활성화
    public void Touch()
    {
        // 터치하지 않으면 반응X
        if (Input.touchCount == 0) return;

        // 첫 번째 터치 정보 불러오기
        Touch touch = Input.GetTouch(0);

        // 캐릭터들이 인식이 됐으면(나 자신 활성화) 
        if(gameObject.activeSelf == true)
        {
            // Plan Finder의 앵커스테이지에서 Ground Plan Stage 제거
            MidAirPositionerBehaviour.Destroy(planFinder);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);

                RaycastHit hitInfo = new RaycastHit();
                if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
                {
                    Debug.Log("hitInfo : " + hitInfo);
                    // 캐릭터1 을 터치하면
                    if (hitInfo.transform.name == "Character_1")
                    {
                        // 나머지 캐릭터들 없애기
                        Destroy(characters[1]);
                        Destroy(characters[2]);
                        Destroy(characters[3]);

                        //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;

                        // 2초 후 커스텀UI 나옴
                        StartCoroutine(CharacterCustom());
                    }

                    // 캐릭터2 를 터치하면
                    if (hitInfo.transform.name == "Character_2")
                    {
                        // 나머지 캐릭터들 없애기
                        Destroy(characters[0]);
                        Destroy(characters[2]);
                        Destroy(characters[3]);

                        //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;

                        // 2초 후 커스텀UI 나옴
                        StartCoroutine(CharacterCustom());
                    }


                    // 캐릭터3 을 터치하면
                    if (hitInfo.transform.name == "Character_3")
                    {
                        // 나머지 캐릭터들 없애기
                        Destroy(characters[0]);
                        Destroy(characters[1]);
                        Destroy(characters[3]);

                        //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;

                        // 2초 후 커스텀UI 나옴
                        StartCoroutine(CharacterCustom());
                    }


                    // 캐릭터4 를 터치하면
                    if (hitInfo.transform.name == "Character_4")
                    {
                        // 나머지 캐릭터들 없애기
                        Destroy(characters[0]);
                        Destroy(characters[1]);
                        Destroy(characters[2]);

                        //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;

                        // 2초 후 커스텀UI 나옴
                        StartCoroutine(CharacterCustom());
                    }

                }

            }
       
               

        }

        IEnumerator CharacterCustom()
        {
            yield return new WaitForSeconds(2);
            customUI.SetActive(true);
        }
    }

 
}
