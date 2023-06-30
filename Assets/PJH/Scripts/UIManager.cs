using System.Collections.Generic;
using UnityEngine;

// object pooling 사용

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

    // UI 생성후 비활성화
    private void InitUIObjectPooling()
    {
        uiPool = new GameObject[uiPoolSize];
        // poolsize는 캐릭터, 카테고리 정보에 따라 바뀌는 것 넣어주기
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

    // UI에서 눌린 버튼을 확인하고 개수 맞춰 UIparent로 이동, 활성화 하도록
    public void MoveToUIParent()
    {
        bottonName = CheckIndex.Instance.bottonName;
        var Items = ItemManager.Instance.items;

        for (int i = 0; i < Items.Count; i++)
        {
            //int buttonNameNumber = i.
            //for (int buttonMameNumber = 0; buttonMameNumber <= buttonNames.Length; buttonMameNumber++)
            //{

                print("반복횟수 확인");
                //if (bottonName == buttonNames[buttonMameNumber])
                //{
                //    print("진입");
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
                    print("진입Hat");
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
                    print("진입Top");//8-10번 돌아야함
                    var itemLength = Items[i];
                    var characterIdxNumber = itemLength.characterIdx;
                    for (int number = 0; number < characterIdxNumber; number++)
                    {
                        print("?");//2-4번 돌아야 함

                        //GameObject instanceui = deactiveUIList[0];
                        //Transform parent = uiparent.transform;
                        //instanceui.transform.SetParent(parent);
                        instanceUI.gameObject.SetActive(true);
                        //deactiveUIList.RemoveAt(0);
                    }
                }
                if (bottonName == "Bottom")
                {
                    print("진입Bottom");
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
