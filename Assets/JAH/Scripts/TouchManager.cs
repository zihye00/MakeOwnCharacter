using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

// 역할 1 : 캐릭터을 터치하면 나 자신만 활성화
// - 나머지 캐릭터들 비활성화

// 역할 2 : 터치 이펙트 추가
// 터치할 때마다 paricle이 나오게 한다
// - 별 파티클
// - 시간 텀

public class TouchManager : MonoBehaviour
{

    // - 나머지 캐릭터들
    public GameObject[] characters;
    // - 커스텀 UI
    public GameObject customUI;
    // - ar 카메라
    public Camera cam;
    // - Midair 인식
    public GameObject midairFinder;


    // 역할 2 : 터치 이펙트 추가
    // -   파티클
    public GameObject effectPref;
    // - 시간 텀
    private float spawnsTime;
    public float defaultTime = 0.05f;

    Vector2 inputPos = Vector2.zero;
    bool isPressed = false;

    private void Update()
    {
        inputPos = Vector2.zero;
        isPressed = false;

        spawnsTime += Time.deltaTime;
        
        UpdateInputInfo();
        Touch();
        //MouseClick();
    }


    private void UpdateInputInfo()
    {
#if UNITY_EDITOR
        // 첫 번째 터치 정보 불러오기       
        inputPos = Input.mousePosition;
        isPressed = Input.GetMouseButton(0);
#else
        // 첫 번째 터치 정보 불러오기
        Touch touch = Input.GetTouch(0);            
        
        // 첫 번째 터치 정보 불러오기       
        inputPos = Input.GetTouch(0).position;
        isPressed = touch.phase == TouchPhase.Began;
#endif
    }

    // 역할 1 : Character_1(나 자신)을 터치하면 나 자신만 활성화
    public void Touch()
    {
#if !UNITY_EDITOR
        // 터치하지 않으면 반응X
        if (Input.touchCount == 0) return;
#endif


        // 캐릭터들이 인식이 됐으면(나 자신 활성화) 
        if (gameObject.activeSelf == true)
        {
            // Plan Finder의 앵커스테이지에서 Ground Plan Stage 제거
            MidAirPositionerBehaviour.Destroy(midairFinder);

            if (isPressed)
            {
                Ray ray = cam.ScreenPointToRay(inputPos);

                RaycastHit hitInfo = new RaycastHit();
                if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
                {
                    Debug.Log("hitInfo : " + hitInfo);
                    // 캐릭터1 을 터치하면
                    if (hitInfo.transform.name == "Character_1")
                    {
                        // 나머지 캐릭터들 없애기
                        //Destroy(characters[1]);
                        //Destroy(characters[2]);
                        //Destroy(characters[3]);

                        //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;
                        //particleActive();

                        // 나머지 캐릭터들 비활성화
                        characters[1].gameObject.SetActive(false);
                        characters[2].gameObject.SetActive(false);
                        characters[3].gameObject.SetActive(false);

                        CheckIndex.Instance.SetCharacterIndex(0);

                        // 2초 후 커스텀UI 나옴
                        StartCoroutine(CharacterCustom());

                    }

                    // 캐릭터2 를 터치하면
                    if (hitInfo.transform.name == "Character_2")
                    {
                        // 나머지 캐릭터들 없애기
                        //Destroy(characters[0]);
                        //Destroy(characters[2]);
                        //Destroy(characters[3]);

                        //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;
                        //particleActive();

                        // 나머지 캐릭터들 비활성화
                        characters[0].gameObject.SetActive(false);
                        characters[2].gameObject.SetActive(false);
                        characters[3].gameObject.SetActive(false);

                        CheckIndex.Instance.SetCharacterIndex(1);


                        // 2초 후 커스텀UI 나옴
                        StartCoroutine(CharacterCustom());

                    }


                    // 캐릭터3 을 터치하면
                    if (hitInfo.transform.name == "Character_3")
                    {
                        // 나머지 캐릭터들 없애기
                        //Destroy(characters[0]);
                        //Destroy(characters[1]);
                        //Destroy(characters[3]);

                        //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;

                        //particleActive();

                        // 나머지 캐릭터들 비활성화
                        characters[0].gameObject.SetActive(false);
                        characters[1].gameObject.SetActive(false);
                        characters[3].gameObject.SetActive(false);

                        CheckIndex.Instance.SetCharacterIndex(2);


                        // 2초 후 커스텀UI 나옴
                        StartCoroutine(CharacterCustom());
                    }


                    // 캐릭터4 를 터치하면
                    if (hitInfo.transform.name == "Character_4")
                    {
                        // 나머지 캐릭터들 없애기
                        //Destroy(characters[0]);
                        //Destroy(characters[1]);
                        //Destroy(characters[2]);

                        //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                        //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;

                        //particleActive();

                        // 나머지 캐릭터들 비활성화
                        characters[0].gameObject.SetActive(false);
                        characters[1].gameObject.SetActive(false);
                        characters[2].gameObject.SetActive(false);

                        CheckIndex.Instance.SetCharacterIndex(3);

                        // 2초 후 커스텀UI 나옴
                        StartCoroutine(CharacterCustom());
                    }
  
                }

            }
       
               

        }
    }

        IEnumerator CharacterCustom()
        {
            yield return new WaitForSeconds(2);
            customUI.SetActive(true);
        }

    // 역할 2 : 터치 이펙트 추가
    private void EffectParticle()
    {
        // 파티클이 나오는 위치.-> 첫번째 터치 위치
        Vector3 pos = Camera.main.ScreenToWorldPoint(inputPos);
        pos.z = 0;
        Instantiate(effectPref, pos, Quaternion.identity);
    }

    // - 일정 시간텀을 두고 파티클이 나오도록
    private void particleActive()
    {
        if (spawnsTime >= defaultTime)
        {
            EffectParticle();
            spawnsTime = 0f;
        }

    }

    // Return 버튼을 누르면 캐릭터들 다시 생성되도록
    public void CharactersActive()
    {
        // 캐릭터4명이 다시 뜸
        for (int cIdx = 0; cIdx < characters.Length; cIdx++)
        {
            characters[cIdx].gameObject.SetActive(true);
            MeshRenderer[] meshes = characters[cIdx].GetComponentsInChildren<MeshRenderer>();

            for (int mIdx = 0; mIdx < meshes.Length; mIdx++)
            {
                meshes[mIdx].enabled = true;
            }
        }
        
        //characters[0].gameObject.SetActive(true);
        //characters[1].gameObject.SetActive(true);
        //characters[2].gameObject.SetActive(true);
        //characters[3].gameObject.SetActive(true);

        // CustomUI 비활성화
        customUI.gameObject.SetActive(false);
    }

    private void MouseClick()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                Debug.Log("hitInfo : " + hitInfo);
                // 캐릭터1 을 터치하면
                if (hitInfo.transform.name == "Character_1")
                {
                    // 나머지 캐릭터들 없애기
                    //Destroy(characters[1]);
                    //Destroy(characters[2]);
                    //Destroy(characters[3]);

                    //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;
                    particleActive();

                    // 나머지 캐릭터들 비활성화
                    characters[1].gameObject.SetActive(false);
                    characters[2].gameObject.SetActive(false);
                    characters[3].gameObject.SetActive(false);

                    CheckIndex.Instance.SetCharacterIndex(0);

                    // 2초 후 커스텀UI 나옴
                    StartCoroutine(CharacterCustom());

                }

                // 캐릭터2 를 터치하면
                if (hitInfo.transform.name == "Character_2")
                {
                    // 나머지 캐릭터들 없애기
                    //Destroy(characters[0]);
                    //Destroy(characters[2]);
                    //Destroy(characters[3]);

                    //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;
                    particleActive();

                    // 나머지 캐릭터들 비활성화
                    characters[0].gameObject.SetActive(false);
                    characters[2].gameObject.SetActive(false);
                    characters[3].gameObject.SetActive(false);

                    CheckIndex.Instance.SetCharacterIndex(1);


                    // 2초 후 커스텀UI 나옴
                    StartCoroutine(CharacterCustom());

                }


                // 캐릭터3 을 터치하면
                if (hitInfo.transform.name == "Character_3")
                {
                    // 나머지 캐릭터들 없애기
                    //Destroy(characters[0]);
                    //Destroy(characters[1]);
                    //Destroy(characters[3]);

                    //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;

                    particleActive();

                    // 나머지 캐릭터들 비활성화
                    characters[0].gameObject.SetActive(false);
                    characters[1].gameObject.SetActive(false);
                    characters[3].gameObject.SetActive(false);

                    CheckIndex.Instance.SetCharacterIndex(2);


                    // 2초 후 커스텀UI 나옴
                    StartCoroutine(CharacterCustom());
                }


                // 캐릭터4 를 터치하면
                if (hitInfo.transform.name == "Character_4")
                {
                    // 나머지 캐릭터들 없애기
                    //Destroy(characters[0]);
                    //Destroy(characters[1]);
                    //Destroy(characters[2]);

                    //hitInfo.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    //cam.transform.localEulerAngles = hitInfo.transform.localEulerAngles;

                    particleActive();

                    // 나머지 캐릭터들 비활성화
                    characters[0].gameObject.SetActive(false);
                    characters[1].gameObject.SetActive(false);
                    characters[2].gameObject.SetActive(false);

                    CheckIndex.Instance.SetCharacterIndex(3);

                    // 2초 후 커스텀UI 나옴
                    StartCoroutine(CharacterCustom());
                }

            }

        }

    }
}

