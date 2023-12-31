using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 역할 1 : Save Button을 누르면 InputField 활성화

public class InputManager : MonoBehaviour
{

    public void InputName()
    {
        BGMManager.Instance.OnTouchButton();

        GameObject character = GameObject.FindGameObjectWithTag("Character");   
        
        // 만약 캐릭터가 활성화 되어있으면
        if ( character.activeSelf == true )
        {
            // 캐릭터 터치 안되도록 콜라이더 비활성화
            character.GetComponent<BoxCollider>().enabled = false;
            // InputField 활성화
            character.transform.Find("Canvas").gameObject.SetActive(true);

        }

    }

    public void NameOff()
    {
        GameObject character = GameObject.FindGameObjectWithTag("Character");
        character.transform.Find("Canvas").gameObject.SetActive(false);
    }

    public void NameOn()
    {
        GameObject character = GameObject.FindGameObjectWithTag("Character");
        character.transform.Find("Canvas").gameObject.SetActive(true);
    }


    public void ColliderOff()
    {
        BGMManager.Instance.OnTouchButton();

        GameObject character = GameObject.FindGameObjectWithTag("Character");

        // 만약 캐릭터가 활성화 되어있으면
        if (character.activeSelf == true)
        {
            // 캐릭터 터치 안되도록 콜라이더 비활성화
            character.GetComponent<BoxCollider>().enabled = false;
  

        }

    }
}
