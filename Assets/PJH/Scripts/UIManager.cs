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
    private int uiPoolSize = 3;
    private List<GameObject> uiPool;
    private List<GameObject> deactiveUIList;

    public GameObject uiparent;

    private string bottonName;
    private int characterIdx;

    private void Start()
    {
        itemUI = Resources.Load<GameObject>("Prefab/ItemUI");

       // InitUIObjectPooling();
    }

    // UI 생성후 비활성화
    private void InitUIObjectPooling()
    {
        uiPool = new List<GameObject>();

        // poolsize는 캐릭터, 카테고리 정보에 따라 바뀌는 것 넣어주기
        deactiveUIList = new List<GameObject>();
        return;

        for (int i = 0; i < uiPoolSize; i++)
        {
            Transform parent = uiparent.transform;
            GameObject instanceUI = Instantiate(itemUI, parent);
            instanceUI.gameObject.SetActive(false);
            uiPool[i] = instanceUI;
            deactiveUIList.Add(instanceUI);
        }
    }

    // UI에서 눌린 버튼을 확인하고 개수 맞춰 UIparent로 이동, 활성화 하도록
    public void MoveToUIParent()
    {
        bottonName = CheckIndex.Instance.bottonName;
        characterIdx = CheckIndex.Instance.characterIndex;

        deactiveUIList = new List<GameObject>();
        uiPool = new List<GameObject>();

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
                    continue;

                GameObject uiItem = null;

                if (deactiveUIList.Count > 0)
                {
                    uiItem = deactiveUIList[0];
                    deactiveUIList.RemoveAt(0);
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

                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{hat.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;


                //UI아이템에 DeactiveList정보를 저장
                if (uiItem.activeSelf == false)
                {
                    deactiveUIList.Add(uiItem);

                }


            }
        }

    }
}
