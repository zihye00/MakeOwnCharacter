using System.Collections.Generic;
using UnityEngine;

// Character Index 저장하는 스크립트
// 저장한 Index에 따라 UI프리팹 생성 다르게 하기

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

    // 캐릭터에 따른 Index저장

    public void SetCharacterIndex(int characterIdx)
    {
        if (character.ContainsKey("Character"))
            character["Character"] = characterIdx;
        else
            character.Add("Character", characterIdx);
    }


    // 캐릭터에 따른 UI 생성
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
