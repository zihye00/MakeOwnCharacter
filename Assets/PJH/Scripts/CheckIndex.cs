using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Character Index �����ϴ� ��ũ��Ʈ
// ������ Index�� ���� UI������ ���� �ٸ��� �ϱ�

public class CheckIndex : MonoBehaviour
{

    public Dictionary<string, int> character = new Dictionary<string, int>();
    public Dictionary<string, string> botton = new Dictionary<string, string>();
    public Dictionary<string, int> itemIdx = new Dictionary<string, int>();

    public string bottonName;
    public int characterIndex;
    public int itemIdxs;
    public Sprite image;


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

    // ĳ���Ϳ� ���� Index����
    public void SetCharacterIndex(int characterIdx)
    {
        if (character.ContainsKey("Character"))
            character["Character"] = characterIdx;
        else
            character.Add("Character", characterIdx);
    }

    // ��ư�� ���� Index����
    public void SetBottonIndex(string bottonName)
    {
        if (botton.ContainsKey("Botton"))
            botton["Botton"] = bottonName;
        else
            botton.Add("Botton", bottonName);
    }
    // ��ư�� ���� itemIndex����
    public void SetItemIndex(int idx)
    {
        if (itemIdx.ContainsKey("ItemIdx"))
            itemIdx["ItemIdx"] = idx;
        else
            itemIdx.Add("ItemIdx", idx);
    }

    // ���ǿ� ���� UI �̹��� ����
    public void SetUIFromDictionary()
    {
        characterIndex = (int)character["Character"];
        bottonName = botton["Botton"]; 
    }
}