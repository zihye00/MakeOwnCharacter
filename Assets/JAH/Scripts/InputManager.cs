using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� : Save Button�� ������ InputField Ȱ��ȭ

public class InputManager : MonoBehaviour
{

  public void InputName()
    {
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
}
