using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIndexInit : MonoBehaviour
{
    public static CharacterIndexInit Instance;

    private void Awake()
    {
        Instance = this;
    }

    int[] characterIdx = new int[4] { 0, 1, 2, 3 };
    string[] buttonName = new string[4] { "Hat", "Top", "Bottom", "Shoes" };
    int[] itemIdx = new int[4] { 0, 1, 2, 3 };
    public List<string> itemName = new List<string>();
    public List<GameObject> Hat = new List<GameObject>();
    public List<GameObject> Top = new List<GameObject>();
    public List<GameObject> Bottom = new List<GameObject>();
    public List<GameObject> Shoes = new List<GameObject>();
    public GameObject uiItem;

    private void Start()
    {
        itemName.Add("Hat00");
        itemName.Add("Hat01");
        itemName.Add("Hat02");
        itemName.Add("Hat03");
        itemName.Add("Hat10");
        itemName.Add("Hat11");
        itemName.Add("Hat20");
        itemName.Add("Hat21");
        itemName.Add("Hat30");
        itemName.Add("Hat31");
        itemName.Add("Top00");
        itemName.Add("Top01");
        itemName.Add("Top10");
        itemName.Add("Top11");
        itemName.Add("Top20");
        itemName.Add("Top21");
        itemName.Add("Top30");
        itemName.Add("Top31");
        itemName.Add("Bottom00");
        itemName.Add("Bottom01");
        itemName.Add("Bottom10");
        itemName.Add("Bottom11");
        itemName.Add("Bottom20");
        itemName.Add("Bottom21");
        itemName.Add("Bottom30");
        itemName.Add("Bottom31");
        itemName.Add("Shoes00");
        itemName.Add("Shoes01");
        itemName.Add("Shoes10");
        itemName.Add("Shoes11");
        itemName.Add("Shoes20");
        itemName.Add("Shoes21");
        itemName.Add("Shoes30");
        itemName.Add("Shoes31");

    }


}
