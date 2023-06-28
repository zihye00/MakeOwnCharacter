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
    public Sprite image;
    public int idx;
}
[System.Serializable]
public class Top
{
    // 1개의 UI에 들어갈 정보
    public string name;
    public Sprite image;
    public int idx;
}
[System.Serializable]
public class Bottom
{
    // 1개의 UI에 들어갈 정보
    public string name;
    public Sprite image;
    public int idx;
}
[System.Serializable]
public class Shoes
{
    // 1개의 UI에 들어갈 정보
    public string name;
    public Sprite image;
    public int idx;
}

[System.Serializable]
public class TopSetList
{
    static void Main(string[] args)
    {
        List<Top> Tops = new List<Top>();

        Top top0A = new Top();
        top0A.name = "Top0A";
        top0A.image = Resources.Load<Sprite>("Prefab/Top0A");
        top0A.idx = 0;

        Top top0B = new Top();
        top0B.name = "Top0B";
        top0B.image = Resources.Load<Sprite>("Prefab/Top0B");
        top0B.idx = 0;
         
        Top top1A = new Top();
        top1A.name = "Top1A";
        top1A.image = Resources.Load<Sprite>("Prefab/Top1A");
        top1A.idx = 1;

        Top top1B = new Top();
        top1B.name = "Top1B";
        top1B.image = Resources.Load<Sprite>("Prefab/Top1B");
        top1B.idx = 1;
 
        Top top2A = new Top();
        top2A.name = "Top2A";
        top2A.image = Resources.Load<Sprite>("Prefab/Top2A");
        top2A.idx = 2;

        Top top2B = new Top();
        top2B.name = "Top2B";
        top2B.image = Resources.Load<Sprite>("Prefab/Top2B");
        top2B.idx = 2;
         
        Top top3A = new Top();
        top3A.name = "Top3A";
        top3A.image = Resources.Load<Sprite>("Prefab/Top3A");
        top3A.idx = 3;

        Top top3B = new Top();
        top3B.name = "Top3B";
        top3B.image = Resources.Load<Sprite>("Prefab/Top3B");
        top3B.idx = 3;

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