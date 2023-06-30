using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// hat, top, bottom, shoes
// class를 List?로 꺼내면 될까?

[System.Serializable]
public class Item
{
    // 1개의 UI에 들어갈 정보
    public string name;
    public string image;
    public int characterIdx;
    public int Idx;
    public string buttonName;
}

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;

    public List<Item> items = new List<Item>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {                  
        Item top0A = new Item();
        top0A.name = "Top0A";
        top0A.image = "Top0A";
        top0A.characterIdx = 0;
        top0A.Idx = 0;
        top0A.buttonName = "Top";
        items.Add(top0A);

        Item top0B = new Item();
        top0B.name = "Top0B";
        top0B.image = "Top0B";
        top0B.characterIdx = 0;
        top0B.Idx = 1;
        top0B.buttonName = "Top";
        items.Add(top0B);

        Item top1A = new Item();
        top1A.name = "Top1A";
        top1A.image = "Top1A";
        top1A.characterIdx = 1;
        top1A.Idx = 0;
        top1A.buttonName = "Top";
        items.Add(top1A);
        
        Item top1B = new Item();
        top1B.name = "Top1B";
        top1B.image = "Top1B";
        top1B.characterIdx = 1;
        top1B.Idx = 1;
        top1B.buttonName = "Top";
        items.Add(top1B);

        Item top2A = new Item();
        top2A.name = "Top2A";
        top2A.image = "Top2A";
        top2A.characterIdx = 2;
        top2A.Idx = 0;
        top2A.buttonName = "Top";
        items.Add(top2A);
        
        Item top2B = new Item();
        top2B.name = "Top2B";
        top2B.image = "Top2B";
        top2B.characterIdx = 2;
        top2B.Idx = 1;
        top2B.buttonName = "Top";
        items.Add(top2B);
         
        Item top3A = new Item();
        top3A.name = "Top3A";
        top3A.image = "Top3A";
        top3A.characterIdx = 3;
        top2A.Idx = 0;
        top2A.buttonName = "Top";
        items.Add(top3A);

        Item top3B = new Item();
        top3B.name = "Top3B";
        top3B.image = "Top3B";
        top3B.characterIdx = 3;
        top2B.Idx = 1;
        top2B.buttonName = "Top";
        items.Add(top3B);

        Item hat0A = new Item();
        hat0A.name = "Hat0A";
        hat0A.image = "Hat0A";
        hat0A.characterIdx = 0;
        hat0A.Idx = 0;
        items.Add(hat0A);

        Item hat0B = new Item();
        hat0B.name = "Hat0B";
        hat0B.image = "Hat0B";
        hat0B.characterIdx = 0;
        hat0B.Idx = 1;
        items.Add(hat0B);

        Item hat0C = new Item();
        hat0C.name = "Hat0C";
        hat0C.image = "Hat0C";
        hat0C.characterIdx = 0;
        hat0C.Idx = 3;
        items.Add(hat0C);

        Item hat0D = new Item();
        hat0D.name = "Hat0D";
        hat0D.image = "Hat0D";
        hat0D.characterIdx = 0;
        hat0D.Idx = 4;
        items.Add(hat0D);

        Item hat1A = new Item();
        hat1A.name = "Hat1A";
        hat1A.image = "Hat1A";
        hat1A.characterIdx = 1;
        hat1A.Idx = 0;
        items.Add(hat1A);

        Item hat1B = new Item();
        hat1B.name = "Hat1B";
        hat1B.image = "Hat1B";
        hat1B.characterIdx = 1;
        hat1B.Idx = 1;
        items.Add(hat1B);

        Item hat2A = new Item();
        hat2A.name = "Hat2A";
        hat2A.image = "Hat2A";
        hat2A.characterIdx = 2;
        hat2A.Idx = 0;
        items.Add(hat2A);

        Item hat2B = new Item();
        hat2B.name = "Hat2B";
        hat2B.image = "Hat2B";
        hat2B.characterIdx = 2;
        hat2B.Idx = 1;
        items.Add(hat2B);

        Item hat3A = new Item();
        hat3A.name = "Hat3A";
        hat3A.image = "Hat3A";
        hat3A.characterIdx = 3;
        hat3A.Idx = 0;
        items.Add(hat3A);

        Item hat3B = new Item();
        hat3B.name = "Hat3B";
        hat3B.image = "Hat3B";
        hat3B.characterIdx = 3;
        hat3B.Idx = 1;
        items.Add(hat3B);

        Item bottom0A = new Item();
        bottom0A.name = "Bottom0A";
        bottom0A.image = "Bottom0A";
        bottom0A.characterIdx = 0;
        bottom0A.Idx = 0;
        items.Add(bottom0A);

        Item bottom0B = new Item();
        bottom0B.name = "Bottom0B";
        bottom0B.image = "Bottom0B";
        bottom0B.characterIdx = 0;
        bottom0B.Idx = 1;
        items.Add(bottom0B);

        Item bottom1A = new Item();
        bottom1A.name = "Bottom1A";
        bottom1A.image = "Bottom1A";
        bottom1A.characterIdx = 1;
        bottom1A.Idx = 0;
        items.Add(bottom1A);

        Item bottom1B = new Item();
        bottom1B.name = "Bottom1B";
        bottom1B.image = "Bottom1B";
        bottom1B.characterIdx = 1;
        bottom1B.Idx = 1;
        items.Add(bottom1B);

        Item bottom2A = new Item();
        bottom2A.name = "Bottom2A";
        bottom2A.image = "Bottom2A";
        bottom2A.characterIdx = 2;
        bottom2A.Idx = 0;
        items.Add(bottom2A);

        Item bottom2B = new Item();
        bottom2B.name = "Bottom2B";
        bottom2B.image = "Bottom2B";
        bottom2B.characterIdx = 2;
        bottom2B.Idx = 1;
        items.Add(bottom2B);

        Item bottom3A = new Item();
        bottom3A.name = "Bottom3A";
        bottom3A.image = "Bottom3A";
        bottom3A.characterIdx = 3;
        bottom3A.Idx = 0;
        items.Add(bottom3A);

        Item bottom3B = new Item();
        bottom3B.name = "Bottom3B";
        bottom3B.image = "Bottom3B";
        bottom3B.characterIdx = 3;
        bottom3B.Idx = 1;
        items.Add(bottom3B);

        Item shoes0A = new Item();
        shoes0A.name = "Shoes0A";
        shoes0A.image = "Shoes0A";
        shoes0A.characterIdx = 0;
        shoes0A.Idx = 0;
        items.Add(shoes0A);

        Item shoes0B = new Item();
        shoes0B.name = "Shoes0B";
        shoes0B.image = "Shoes0B";
        shoes0B.characterIdx = 0;
        shoes0B.Idx = 1;
        items.Add(shoes0B);

        Item shoes1A = new Item();
        shoes1A.name = "Shoes1A";
        shoes1A.image = "Shoes1A";
        shoes1A.characterIdx = 1;
        shoes1A.Idx = 0;
        items.Add(shoes1A);

        Item shoes1B = new Item();
        shoes1B.name = "Shoes1B";
        shoes1B.image = "Shoes1B";
        shoes1B.characterIdx = 1;
        shoes1B.Idx = 1;
        items.Add(shoes1B);

        Item shoes2A = new Item();
        shoes2A.name = "Shoes2A";
        shoes2A.image = "Shoes2A";
        shoes2A.characterIdx = 2;
        shoes2A.Idx = 0;
        items.Add(shoes2A);

        Item shoes2B = new Item();
        shoes2B.name = "Shoes2B";
        shoes2B.image = "Shoes2B";
        shoes2B.characterIdx = 2;
        shoes2B.Idx = 1;
        items.Add(shoes2B);

        Item shoes3A = new Item();
        shoes3A.name = "Shoes3A";
        shoes3A.image = "Shoes3A";
        shoes3A.characterIdx = 3;
        shoes3A.Idx = 0;
        items.Add(shoes3A);

        Item shoes3B = new Item();
        shoes3B.name = "Shoes3B";
        shoes3B.image = "Shoes3B";
        shoes3B.characterIdx = 3;
        shoes3B.Idx = 1;
        items.Add(shoes3B);
    }
}