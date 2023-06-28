using System.Collections;
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

    // 캐릭터에 따른 Index저장

    public void SetCharacterIndex(string character)
    {
        if (characterIndex.ContainsKey("Character"))
            characterIndex["Character"] = character;
        else      
            characterIndex.Add("Character", character);        
    }

    // 캐릭터에 따른 UI 생성
    public void InstanceUI()
    {
        
    }
}
