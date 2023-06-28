using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Character Index �����ϴ� ��ũ��Ʈ
// ������ Index�� ���� UI������ ���� �ٸ��� �ϱ�

public class CheckIndex : MonoBehaviour
{
    private static CheckIndex instance;

    public static CheckIndex Instance
    {
        get
        {
            if(instance == null)
            {
                DontDestroyOnLoad(Instance);
            }
            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

    Dictionary<string, string> characterIndex = new Dictionary<string, string>();

    // ĳ���Ϳ� ���� Index����

    public void SetCharacterIndex(string character)
    {
        if (characterIndex.ContainsKey("Character"))
            characterIndex["Character"] = character;
        else      
            characterIndex.Add("Character", character);        
    }

    // ĳ���Ϳ� ���� UI ����
    public void InstanceUI()
    {
        
    }
}
