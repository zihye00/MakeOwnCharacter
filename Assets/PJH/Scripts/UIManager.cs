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

    // UI ������ ��Ȱ��ȭ
    private void InitUIObjectPooling()
    {
        uiPool = new List<GameObject>();

        // poolsize�� ĳ����, ī�װ� ������ ���� �ٲ�� �� �־��ֱ�
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

    // UI���� ���� ��ư�� Ȯ���ϰ� ���� ���� UIparent�� �̵�, Ȱ��ȭ �ϵ���
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

        // UI Tem ����(�ٽú�����) -> ��������
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
                // UIPrefab�� ���� ��������

                Sprite sprite = Resources.Load<Sprite>($"Sprite/{bottonName}{characterIdx}{hat.Idx}");
                uiItem.GetComponent<UIPrefab>().image.GetComponent<Image>().sprite = sprite;


                //UI�����ۿ� DeactiveList������ ����
                if (uiItem.activeSelf == false)
                {
                    deactiveUIList.Add(uiItem);

                }


            }
        }

    }
}
