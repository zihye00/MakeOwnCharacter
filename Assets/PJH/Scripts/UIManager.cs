using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// object pooling 사용

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private GameObject itemUI;
    private int uiPoolSize = 2;
    [SerializeField]

    public List<GameObject> uiPool;
    [SerializeField]

    public List<GameObject> deactiveUIList;

    public GameObject uiparent;

    private string bottonName;
    private int characterIdx;
    private int idx;
    private string characterName;

    private void Start()
    {
        itemUI = Resources.Load<GameObject>("Prefab/ItemUI");

        InitUIObjectPooling();
    }

    // UI 생성후 비활성화
    private void InitUIObjectPooling()
    {

        for (int i = 0; i < uiPoolSize; i++)
        {
            Transform parent = uiparent.transform;
            GameObject instanceUI = Instantiate(itemUI, parent);
            instanceUI.gameObject.SetActive(false);
            deactiveUIList.Add(instanceUI);
        }
    }

    // UI에서 눌린 버튼을 확인하고 개수 맞춰 UIparent로 이동, 활성화 하도록
    public void MoveToUIParent()
    {
        bottonName = CheckIndex.Instance.bottonName;
        characterIdx = CheckIndex.Instance.characterIndex;
        characterName = ItemManager.Instance.name;

        var tops = ItemManager.Instance.Tops;
        List<Item> hats = ItemManager.Instance.Hats;
        var bottoms = ItemManager.Instance.Bottoms;
        var shoes = ItemManager.Instance.Shoes;

        // UI Tem 생성(다시봐보기) -> 구조이해
        if (bottonName == "Hat")
        {
            for (int i = 0; i < hats.Count; i++)
            {
                var hat = hats[i];
                if (hat.characterIdx != characterIdx)
                {

                    continue;
                }
                GameObject uiItem = null;

                // uiItem이 사용 될때
                if (deactiveUIList.Count > 0)
                {
                    uiItem = deactiveUIList[0];
                    uiItem.SetActive(true);
                    deactiveUIList.RemoveAt(0);
                    uiPool.Add(uiItem);
                }
                else
                {
                    Transform parent = uiparent.transform;
                    uiItem = Instantiate(itemUI, parent);
                    uiPool.Add(uiItem);
                }
                // 사용하고 다른 버튼 눌렀을때 UI deactive 하기


                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{hat.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;
                //name가져오기
                characterName = $"{bottonName}{characterIdx}{hat.Idx}";
                uiItem.GetComponent<UIPrefab>().name = characterName;
            }
        }
        // UI Tem 생성(다시봐보기) -> 구조이해
        if (bottonName == "Top")
        {
            for (int i = 0; i < tops.Count; i++)
            {
                var top = tops[i];
                if (top.characterIdx != characterIdx)
                {
                    continue;
                }

                GameObject uiItem = null;

                if (deactiveUIList.Count > 0)
                {
                    uiItem = deactiveUIList[0];
                    deactiveUIList.RemoveAt(0);
                    uiItem.SetActive(true);
                    uiPool.Add(uiItem);
                }
                else
                {
                    Transform parent = uiparent.transform;
                    uiItem = Instantiate(itemUI, parent);
                    uiPool.Add(uiItem);
                }

                // uiItem
                // UIPrefab의 정보 가져오기

                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{top.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;
                //name가져오기
                characterName = $"{bottonName}{characterIdx}{top.Idx}";
                uiItem.GetComponent<UIPrefab>().name = characterName;
            }
        }
        // UI Tem 생성(다시봐보기) -> 구조이해
        if (bottonName == "Bottom")
        {
            for (int i = 0; i < bottoms.Count; i++)
            {
                var bottom = bottoms[i];
                if (bottom.characterIdx != characterIdx)
                {
                    continue;
                }

                GameObject uiItem = null;

                if (deactiveUIList.Count > 0)
                {
                    uiItem = deactiveUIList[0];
                    deactiveUIList.RemoveAt(0);
                    uiItem.SetActive(true);
                    uiPool.Add(uiItem);
                }
                else
                {
                    Transform parent = uiparent.transform;
                    uiItem = Instantiate(itemUI, parent);
                    uiPool.Add(uiItem);
                }

                // uiItem
                // UIPrefab의 정보 가져오기

                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{bottom.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;
                //name가져오기
                characterName = $"{bottonName}{characterIdx}{bottom.Idx}";
                uiItem.GetComponent<UIPrefab>().name = characterName;
            }
        }
        // UI Tem 생성(다시봐보기) -> 구조이해
        if (bottonName == "Shoes")
        {
            for (int i = 0; i < shoes.Count; i++)
            {
                var shoe = shoes[i];
                if (shoe.characterIdx != characterIdx)
                {
                    continue;
                }

                GameObject uiItem = null;

                if (deactiveUIList.Count > 0)
                {
                    uiItem = deactiveUIList[0];
                    deactiveUIList.RemoveAt(0);
                    uiItem.SetActive(true);
                    uiPool.Add(uiItem);
                }
                else
                {
                    Transform parent = uiparent.transform;
                    uiItem = Instantiate(itemUI, parent);
                    uiPool.Add(uiItem);
                }

                // uiItem
                // UIPrefab의 정보 가져오기

                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{shoe.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;
                //name가져오기
                characterName = $"{bottonName}{characterIdx}{shoe.Idx}";
                uiItem.GetComponent<UIPrefab>().name = characterName;
            }
        }
    }

    public void AddDeactiveUI()
    {

        if (uiPool.Count > 0)
        {
            for (int i = 0; i < uiPool.Count; i++)
            {
                GameObject uiItem = uiPool[i].gameObject;
                uiItem.gameObject.SetActive(false);
                deactiveUIList.Add(uiItem);
            }
        }
    }
}
