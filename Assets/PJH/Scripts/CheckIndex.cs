using System.Collections.Generic;
using UnityEngine;

// Character Index 저장하는 스크립트
// 저장한 Index에 따라 UI프리팹 생성 다르게 하기

public class CheckIndex : MonoBehaviour
{

    public Dictionary<string, int> character = new Dictionary<string, int>();
    public Dictionary<string, string> botton = new Dictionary<string, string>();

    public string bottonName;
    public int characterIndex;
    public int itemIdx;
    public GameObject image;


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

    // 캐릭터에 따른 Index저장
    public void SetCharacterIndex(int characterIdx)
    {
        if (character.ContainsKey("Character"))
            character["Character"] = characterIdx;
        else
            character.Add("Character", characterIdx);
    }

    // 버튼에 따른 Index저장
    public void SetBottonIndex(string bottonName)
    {
        if (botton.ContainsKey("Botton"))
            botton["Botton"] = bottonName;
        else
            botton.Add("Botton", bottonName);
    }

    // 조건에 따른 UI 이미지 생성
    public void SetUIFromDictionary()
    {
        characterIndex = (int)character["Character"];
        bottonName = botton["Botton"];
        var Items = ItemManager.Instance.items;

        for (int i = 0; i < Items.Count; i++)
        {
            Item item = Items[i];
            if (item.characterIdx == characterIndex)
            {
                image = Resources.Load<GameObject>($"Prefab/{bottonName}{characterIndex}{item.Idx}");
            }            
        }        
    }
}