using System.Collections.Generic;
using UnityEngine;

// Character Index 저장하는 스크립트
// 저장한 Index에 따라 UI프리팹 생성 다르게 하기

public class CheckIndex : MonoBehaviour
{

    public Dictionary<string, int> character = new Dictionary<string, int>();
    public Dictionary<string, string> botton = new Dictionary<string, string>();
    public List<Top> tops = new List<Top>();


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

        int characterIndex = (int)character["Character"];
        string bottonName = botton["Botton"];

        var Tops = ItemManager.Instance.Tops;

        for (int i = 0; i <= Tops.Count; i++)
        {
            var top = Tops[i];
            if (top.characterIdx == characterIndex)
            {
                Resources.Load<GameObject>($"Prefab/{bottonName}{characterIndex}{top.Idx}");
            }            
        }        
      



        //for (int i = 0; i >= 12; i++)
        //{
        //    if (tops[i].idx == characterIndex)
        //    {
        //        Sprite topA = Resources.Load<Sprite>($"Prefab/TopA{characterIndex}");
        //        Sprite topB = Resources.Load<Sprite>($"Prefab/TopB{characterIndex}");
        //        Instantiate(topA);
        //        Instantiate(topB);
        //    }
        //}

        //Sprite hat = Resources.Load<Sprite>($"Prefab/Hat{characterIndex}");
        //Sprite top = Resources.Load<Sprite>($"Prefab/Top{characterIndex}");
        //Sprite bottom = Resources.Load<Sprite>($"Prefab/Bottom{characterIndex}");
        //Sprite Shoes = Resources.Load<Sprite>($"Prefab/Shoes{characterIndex}");

    }
}
