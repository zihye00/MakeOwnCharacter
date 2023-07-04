using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� 1 : Save Button�� ������ InputField Ȱ��ȭ

public class InputManager : MonoBehaviour
{

    public void InputName()
    {
        BGMManager.Instance.OnTouchButton();

        GameObject character = GameObject.FindGameObjectWithTag("Character");   
        
        // ���� ĳ���Ͱ� Ȱ��ȭ �Ǿ�������
        if ( character.activeSelf == true )
        {
            // ĳ���� ��ġ �ȵǵ��� �ݶ��̴� ��Ȱ��ȭ
            character.GetComponent<BoxCollider>().enabled = false;
            // InputField Ȱ��ȭ
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

        // ���� ĳ���Ͱ� Ȱ��ȭ �Ǿ�������
        if (character.activeSelf == true)
        {
            // ĳ���� ��ġ �ȵǵ��� �ݶ��̴� ��Ȱ��ȭ
            character.GetComponent<BoxCollider>().enabled = false;
  

        }

    }
}
