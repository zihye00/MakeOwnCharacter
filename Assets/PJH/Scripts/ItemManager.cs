using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// hat, top, bottom, shoes
// class를 List?로 꺼내면 될까?


[System.Serializable]
public class Hat
{
    // 1개의 UI에 들어갈 정보
    public string name;
    public string image;
    public int idx;
}
[System.Serializable]
public class Top
{
    // 1개의 UI에 들어갈 정보
    public string name;
    public string image;
    public int characterIdx;
    public int Idx;
}
[System.Serializable]
public class Bottom
{
    // 1개의 UI에 들어갈 정보
    public string name;
    public string image;
    public int idx;
}
[System.Serializable]
public class Shoes
{
    // 1개의 UI에 들어갈 정보
    public string name;
    public string image;
    public int idx;
}

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;

    public List<Top> Tops = new List<Top>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {                  
        Top top0A = new Top();
        top0A.name = "Top0A";
        top0A.image = "Top0A";
        top0A.characterIdx = 0;
        top0A.Idx = 0;

        Top top0B = new Top();
        top0B.name = "Top0B";
        top0B.image = "Top0B";
        top0B.characterIdx = 0;
        top0B.Idx = 1;

        Top top1A = new Top();
        top1A.name = "Top1A";
        top1A.image = "Top1A";
        top1A.characterIdx = 1;
        top1A.Idx = 0;
        
        Top top1B = new Top();
        top1B.name = "Top1B";
        top1B.image = "Top1B";
        top1B.characterIdx = 1;
        top1B.Idx = 1;

        Top top2A = new Top();
        top2A.name = "Top2A";
        top2A.image = "Top2A";
        top2A.characterIdx = 2;
        
        Top top2B = new Top();
        top2B.name = "Top2B";
        top2B.image = "Top2B";
        top2B.characterIdx = 2;
         
        Top top3A = new Top();
        top3A.name = "Top3A";
        top3A.image = "Top3A";
        top3A.characterIdx = 3;

        Top top3B = new Top();
        top3B.name = "Top3B";
        top3B.image = "Top3B";
        top3B.characterIdx = 3;

        Tops.Add(top0A);
        Tops.Add(top0B);
        Tops.Add(top1A);
        Tops.Add(top1B);
        Tops.Add(top2A);
        Tops.Add(top2B);
        Tops.Add(top3A);
        Tops.Add(top3B);
    }
}