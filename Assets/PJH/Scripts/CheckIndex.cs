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
            if (instance == null)
            {
                DontDestroyOnLoad(Instance);
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

    public Dictionary<string, int> character = new Dictionary<string, int>();

    // ĳ���Ϳ� ���� Index����

    public void SetCharacterIndex(int characterIdx)
    {
        if (character.ContainsKey("Character"))
            character["Character"] = characterIdx;
        else
            character.Add("Character", characterIdx);
    }


    // ĳ���Ϳ� ���� UI ����
    public void SetCharacterFromDictionary()
    {
        int characterIndex = (int)character["Character"];

        for (int i = 0; i >= 12; i++)
        {
            Sprite items = Resources.Load<Sprite>($"Prefab/Item{characterIndex}");
            Instantiate(items);
        }

        //Sprite hat = Resources.Load<Sprite>($"Prefab/Hat{characterIndex}");
        //Sprite top = Resources.Load<Sprite>($"Prefab/Top{characterIndex}");
        //Sprite bottom = Resources.Load<Sprite>($"Prefab/Bottom{characterIndex}");
        //Sprite Shoes = Resources.Load<Sprite>($"Prefab/Shoes{characterIndex}");

    }
}
