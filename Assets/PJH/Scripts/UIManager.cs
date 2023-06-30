using System.Collections.Generic;
using UnityEngine;

// object pooling ���

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private GameObject itemUI;
    private GameObject instanceUI;
    private int uiPoolSize = 3;
    private GameObject[] uiPool;
    private List<GameObject> deactiveUIList;

    public GameObject uiparent;

    private string bottonName;
    private int characterIdx;

    //public List<Item> items = new List<Item>();
    private string[] buttonNames = new string[4] { "Hat", "Top", "Bottom", "shoes" };

    private void Start()
    {
        itemUI = Resources.Load<GameObject>("Prefab/ItemUI");

        InitUIObjectPooling();
    }

    // UI ������ ��Ȱ��ȭ
    private void InitUIObjectPooling()
    {
        uiPool = new GameObject[uiPoolSize];
        // poolsize�� ĳ����, ī�װ� ������ ���� �ٲ�� �� �־��ֱ�
        deactiveUIList = new List<GameObject>();
        for (int i = 0; i < uiPoolSize; i++)
        {
            Transform parent = uiparent.transform;
            instanceUI = Instantiate(itemUI, parent);
            instanceUI.gameObject.SetActive(false);
            uiPool[i] = instanceUI;
            deactiveUIList.Add(instanceUI);
        }
    }

    // UI���� ���� ��ư�� Ȯ���ϰ� ���� ���� UIparent�� �̵�, Ȱ��ȭ �ϵ���
    public void MoveToUIParent()
    {
        bottonName = CheckIndex.Instance.bottonName;
        var Items = ItemManager.Instance.items;

        for (int i = 0; i < Items.Count; i++)
        {
            //int buttonNameNumber = i.
            //for (int buttonMameNumber = 0; buttonMameNumber <= buttonNames.Length; buttonMameNumber++)
            //{

                print("�ݺ�Ƚ�� Ȯ��");
                //if (bottonName == buttonNames[buttonMameNumber])
                //{
                //    print("����");
                //    var itemLength = Items[i];
                //    var characterIdxNumber = itemLength.characterIdx;
                //    for (int number = 0; number < characterIdxNumber; number++)
                //    {
                //        GameObject instanceui = deactiveUIList[0];
                //        //Transform parent = uiparent.transform;
                //        //instanceui.transform.SetParent(parent);
                //        instanceui.gameObject.SetActive(true);
                //        deactiveUIList.RemoveAt(0);
                //    }
                //}
                if (bottonName == "Hat")
                {
                    print("����Hat");
                    var itemLength = Items[i];
                    var characterIdxNumber = itemLength.characterIdx;
                    for (int number = 0; number < characterIdxNumber; number++)
                    {
                        GameObject instanceui = deactiveUIList[0];
                        //Transform parent = uiparent.transform;
                        //instanceui.transform.SetParent(parent);
                        instanceui.gameObject.SetActive(true);
                        deactiveUIList.RemoveAt(0);
                    }
                }
                if (bottonName == "Top")
                {
                    print("����Top");//8-10�� ���ƾ���
                    var itemLength = Items[i];
                    var characterIdxNumber = itemLength.characterIdx;
                    for (int number = 0; number < characterIdxNumber; number++)
                    {
                        print("?");//2-4�� ���ƾ� ��

                        //GameObject instanceui = deactiveUIList[0];
                        //Transform parent = uiparent.transform;
                        //instanceui.transform.SetParent(parent);
                        instanceUI.gameObject.SetActive(true);
                        //deactiveUIList.RemoveAt(0);
                    }
                }
                if (bottonName == "Bottom")
                {
                    print("����Bottom");
                    var itemLength = Items[i];
                    var characterIdxNumber = itemLength.characterIdx;
                    for (int number = 0; number < characterIdxNumber; number++)
                    {
                        GameObject instanceui = deactiveUIList[0];
                        //Transform parent = uiparent.transform;
                        //instanceui.transform.SetParent(parent);
                        instanceui.gameObject.SetActive(true);
                        deactiveUIList.RemoveAt(0);
                    }
                }
                if (bottonName == "Shoes")
                {
                    print("Shoes");
                    var itemLength = Items[i];
                    var characterIdxNumber = itemLength.characterIdx;
                    for (int number = 0; number < characterIdxNumber; number++)
                    {
                        GameObject instanceui = deactiveUIList[0];
                        //Transform parent = uiparent.transform;
                        //instanceui.transform.SetParent(parent);
                        instanceui.gameObject.SetActive(true);
                        deactiveUIList.RemoveAt(0);
                    }
                }
            //}

        }
    }
}
