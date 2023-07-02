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

    public List<Item> Tops = new List<Item>();
    public List<Item> Hats = new List<Item>();
    public List<Item> Bottoms = new List<Item>();
    public List<Item> Shoes = new List<Item>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {                  
        Item top00 = new Item();
        top00.name = "Top00";
        top00.image = "Top00";
        top00.characterIdx = 0;
        top00.Idx = 0;
        top00.buttonName = "Top";
        
        Tops.Add(top00);
        items.Add(top00);
        

        Item top01 = new Item();
        top01.name = "Top01";
        top01.image = "Top01";
        top01.characterIdx = 0;
        top01.Idx = 1;
        top01.buttonName = "Top";

        Tops.Add(top01);
        items.Add(top01);


        Item top10 = new Item();
        top10.name = "Top10";
        top10.image = "Top10";
        top10.characterIdx = 1;
        top10.Idx = 0;
        top10.buttonName = "Top";

        Tops.Add(top10);
        items.Add(top10);
        
        Item top11 = new Item();
        top11.name = "Top11";
        top11.image = "Top11";
        top11.characterIdx = 1;
        top11.Idx = 1;
        top11.buttonName = "Top";
        Tops.Add(top11);
        items.Add(top11);

        Item top20 = new Item();
        top20.name = "Top20";
        top20.image = "Top20";
        top20.characterIdx = 2;
        top20.Idx = 0;
        top20.buttonName = "Top";
        Tops.Add(top20);
        items.Add(top20);
        
        Item top21 = new Item();
        top21.name = "Top21";
        top21.image = "Top21";
        top21.characterIdx = 2;
        top21.Idx = 1;
        top21.buttonName = "Top";
        Tops.Add(top21);
        items.Add(top21);
         
        Item top30 = new Item();
        top30.name = "Top30";
        top30.image = "Top30";
        top30.characterIdx = 3;
        top20.Idx = 0;
        top20.buttonName = "Top";
        Tops.Add(top30);
        items.Add(top30);

        Item top31 = new Item();
        top31.name = "Top31";
        top31.image = "Top31";
        top31.characterIdx = 3;
        top31.Idx = 1;
        top31.buttonName = "Top";
        Tops.Add(top31);
        items.Add(top31);

        Item hat00 = new Item();
        hat00.name = "Hat00";
        hat00.image = "Hat00";
        hat00.characterIdx = 0;
        hat00.Idx = 0;
        hat00.buttonName = "Hat";
        Hats.Add(hat00);
        items.Add(hat00);


        Item hat01 = new Item();
        hat01.name = "Hat01";
        hat01.image = "Hat01";
        hat01.characterIdx = 0;
        hat01.Idx = 1;
        hat01.buttonName = "Hat";
        Hats.Add(hat01);
        items.Add(hat01);


        Item hat02 = new Item();
        hat02.name = "Hat02";
        hat02.image = "Hat02";
        hat02.characterIdx = 0;
        hat02.Idx = 2;
        hat02.buttonName = "Hat";

        Hats.Add(hat02);
        items.Add(hat02);

        Item hat03 = new Item();
        hat03.name = "Hat03";
        hat03.image = "Hat03";
        hat03.characterIdx = 0;
        hat03.Idx = 3;
        hat03.buttonName = "Hat";
        Hats.Add(hat03);
        items.Add(hat03);

        Item hat10 = new Item();
        hat10.name = "Hat10";
        hat10.image = "Hat10";
        hat10.characterIdx = 1;
        hat10.Idx = 0;
        hat10.buttonName = "Hat";
        Hats.Add(hat10);
        items.Add(hat10);

        Item hat11 = new Item();
        hat11.name = "Hat11";
        hat11.image = "Hat11";
        hat11.characterIdx = 1;
        hat11.Idx = 1;
        hat11.buttonName = "Hat";
        Hats.Add(hat11);
        items.Add(hat11);

        Item hat20 = new Item();
        hat20.name = "Hat20";
        hat20.image = "Hat20";
        hat20.characterIdx = 2;
        hat20.Idx = 0;
        hat20.buttonName = "Hat";
        Hats.Add(hat20);
        items.Add(hat20);

        Item hat21 = new Item();
        hat21.name = "Hat21";
        hat21.image = "Hat21";
        hat21.characterIdx = 2;
        hat21.Idx = 1;
        hat21.buttonName = "Hat";
        Hats.Add(hat21);
        items.Add(hat21);

        Item hat30 = new Item();
        hat30.name = "Hat30";
        hat30.image = "Hat30";
        hat30.characterIdx = 3;
        hat30.Idx = 0;
        hat30.buttonName = "Hat";
        Hats.Add(hat30);
        items.Add(hat30);

        Item hat31 = new Item();
        hat31.name = "Hat31";
        hat31.image = "Hat31";
        hat31.characterIdx = 3;
        hat31.Idx = 1;
        hat31.buttonName = "Hat";
        Hats.Add(hat31);
        items.Add(hat31);

        Item bottom00 = new Item();
        bottom00.name = "Bottom00";
        bottom00.image = "Bottom00";
        bottom00.characterIdx = 0;
        bottom00.Idx = 0;
        bottom00.buttonName = "Bottom";
        Bottoms.Add(bottom00);
        items.Add(bottom00);

        Item bottom0B = new Item();
        bottom0B.name = "Bottom0B";
        bottom0B.image = "Bottom0B";
        bottom0B.characterIdx = 0;
        bottom0B.Idx = 1;
        bottom0B.buttonName = "Bottom";
        Bottoms.Add(bottom0B);
        items.Add(bottom0B);

        Item bottom10 = new Item();
        bottom10.name = "Bottom10";
        bottom10.image = "Bottom10";
        bottom10.characterIdx = 1;
        bottom10.Idx = 0;
        bottom10.buttonName = "Bottom";
        Bottoms.Add(bottom10);
        items.Add(bottom10);

        Item bottom11 = new Item();
        bottom11.name = "Bottom11";
        bottom11.image = "Bottom11";
        bottom11.characterIdx = 1;
        bottom11.Idx = 1;
        bottom11.buttonName = "Bottom";
        Bottoms.Add(bottom11);
        items.Add(bottom11);

        Item bottom20 = new Item();
        bottom20.name = "Bottom20";
        bottom20.image = "Bottom20";
        bottom20.characterIdx = 2;
        bottom20.Idx = 0;
        bottom20.buttonName = "Bottom";
        Bottoms.Add(bottom20);
        items.Add(bottom20);

        Item bottom21 = new Item();
        bottom21.name = "Bottom21";
        bottom21.image = "Bottom21";
        bottom21.characterIdx = 2;
        bottom21.Idx = 1;
        bottom21.buttonName = "Bottom";
        Bottoms.Add(bottom21);
        items.Add(bottom21);

        Item bottom30 = new Item();
        bottom30.name = "Bottom30";
        bottom30.image = "Bottom30";
        bottom30.characterIdx = 3;
        bottom30.Idx = 0;
        bottom30.buttonName = "Bottom";
        Bottoms.Add(bottom30);
        items.Add(bottom30);

        Item bottom31 = new Item();
        bottom31.name = "Bottom31";
        bottom31.image = "Bottom31";
        bottom31.characterIdx = 3;
        bottom31.Idx = 1;
        bottom31.buttonName = "Bottom";
        Bottoms.Add(bottom31);
        items.Add(bottom31);

        Item shoes00 = new Item();
        shoes00.name = "Shoes00";
        shoes00.image = "Shoes00";
        shoes00.characterIdx = 0;
        shoes00.Idx = 0;
        shoes00.buttonName = "Shoes";
        Shoes.Add(shoes00);
        items.Add(shoes00);

        Item shoes01 = new Item();
        shoes01.name = "Shoes01";
        shoes01.image = "Shoes01";
        shoes01.characterIdx = 0;
        shoes01.Idx = 1;
        shoes01.buttonName = "Shoes";
        Shoes.Add(shoes01);
        items.Add(shoes01);

        Item shoes10 = new Item();
        shoes10.name = "Shoes10";
        shoes10.image = "Shoes10";
        shoes10.characterIdx = 1;
        shoes10.Idx = 0;
        shoes10.buttonName = "Shoes";
        Shoes.Add(shoes10);
        items.Add(shoes10);

        Item shoes11 = new Item();
        shoes11.name = "Shoes11";
        shoes11.image = "Shoes11";
        shoes11.characterIdx = 1;
        shoes11.Idx = 1;
        shoes11.buttonName = "Shoes";
        Shoes.Add(shoes11);
        items.Add(shoes11);

        Item shoes20 = new Item();
        shoes20.name = "Shoes20";
        shoes20.image = "Shoes20";
        shoes20.characterIdx = 2;
        shoes20.Idx = 0;
        shoes20.buttonName = "Shoes";
        Shoes.Add(shoes20);
        items.Add(shoes20);

        Item shoes21 = new Item();
        shoes21.name = "Shoes21";
        shoes21.image = "Shoes21";
        shoes21.characterIdx = 2;
        shoes21.Idx = 1;
        shoes21.buttonName = "Shoes";
        Shoes.Add(shoes21);
        items.Add(shoes21);

        Item shoes30 = new Item();
        shoes30.name = "Shoes30";
        shoes30.image = "Shoes30";
        shoes30.characterIdx = 3;
        shoes30.Idx = 0;
        shoes30.buttonName = "Shoes";
        Shoes.Add(shoes30);
        items.Add(shoes30);

        Item shoes31 = new Item();
        shoes31.name = "Shoes31";
        shoes31.image = "Shoes31";
        shoes31.characterIdx = 3;
        shoes31.Idx = 1;
        shoes31.buttonName = "Shoes";
        Shoes.Add(shoes31);
        items.Add(shoes31);
    }
}