using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// ���� 1: ���� ó�� �����Ҷ� ��ü,UI���� Instansiate
// ���� 2: ĳ���� ������ ����, �ε�
// - ĳ���� �̸���
// - ĳ���� ��

public class GameManager : MonoBehaviour
{
    // - ĳ���� �̸� ���尪
    public TMP_InputField inputName;
    // - �̱������� ����
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    // ���� 2: ĳ���� �����͸� ����
    public void Save()
    {
        Debug.Log("�۵�!  Save" + inputName.text);
        // ĳ���� �̸� ���� ������
        PlayerPrefs.SetString("Name", inputName.text);
        // ĳ���� ������ Index ��ȣ�� �ο��ϴ� ��ũ��Ʈ�� �����.
        // Index ��ȣ�� PlayerPrefs�� ���� �����Ѵ�
        //PlayerPrefs.SetInt("Index" )

            // ���� ĳ���� �̸��� "Character + Index" �� ���ϰ� Resoruces �� ���������� ����
        // --> ���������� ����!

    }

    // ���� 2: ĳ���� ������ �ε�
    public void Load()
    {
        Debug.Log("�۵�2! Load");
        if (PlayerPrefs.HasKey("Name"))
        {
            Debug.Log("�۵�2!" + PlayerPrefs.GetString("Name"));
            inputName.text = PlayerPrefs.GetString("Name");
            // ĳ������ �ε��� ��ȣ�� �ҷ��´�
            // �ν��Ͻÿ���Ʈ!(character + index )
         
        }
    }

}
