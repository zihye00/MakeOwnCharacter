using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// object pooling ���

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

    // UI ������ ��Ȱ��ȭ
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

    // UI���� ���� ��ư�� Ȯ���ϰ� ���� ���� UIparent�� �̵�, Ȱ��ȭ �ϵ���
    public void MoveToUIParent()
    {
        bottonName = CheckIndex.Instance.bottonName;
        characterIdx = CheckIndex.Instance.characterIndex;
        characterName = ItemManager.Instance.name;

        var tops = ItemManager.Instance.Tops;
        List<Item> hats = ItemManager.Instance.Hats;
        var bottoms = ItemManager.Instance.Bottoms;
        var shoes = ItemManager.Instance.Shoes;

        // UI Tem ����(�ٽú�����) -> ��������
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

                // uiItem�� ��� �ɶ�
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
                // ����ϰ� �ٸ� ��ư �������� UI deactive �ϱ�


                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{hat.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;
                //name��������
                characterName = $"{bottonName}{characterIdx}{hat.Idx}";
                uiItem.GetComponent<UIPrefab>().name = characterName;
            }
        }
        // UI Tem ����(�ٽú�����) -> ��������
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
                // UIPrefab�� ���� ��������

                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{top.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;
                //name��������
                characterName = $"{bottonName}{characterIdx}{top.Idx}";
                uiItem.GetComponent<UIPrefab>().name = characterName;
            }
        }
        // UI Tem ����(�ٽú�����) -> ��������
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
                // UIPrefab�� ���� ��������

                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{bottom.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;
                //name��������
                characterName = $"{bottonName}{characterIdx}{bottom.Idx}";
                uiItem.GetComponent<UIPrefab>().name = characterName;
            }
        }
        // UI Tem ����(�ٽú�����) -> ��������
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
                // UIPrefab�� ���� ��������

                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{shoe.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;
                //name��������
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
