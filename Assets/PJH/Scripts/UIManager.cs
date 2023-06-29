using System.Collections.Generic;
using UnityEngine;

// object pooling ���

public class UIManager : MonoBehaviour
{
    private GameObject itemUI;
    public int uiPoolSize = 1;
    private GameObject[] uiPool;
    private List<GameObject> deactiveUIList;

    public GameObject uiparent;

    public List<Top> tops = new List<Top>();

    private void Start()
    {
        itemUI = Resources.Load<GameObject>("Prefab/ItemUI");

        InitUIObjectPooling();
    }

    // UI ������ ��Ȱ��ȭ
    private void InitUIObjectPooling()
    {
        uiPool = new GameObject[uiPoolSize];
        deactiveUIList = new List<GameObject>();
        // poolsize�� ĳ����, ī�װ� ������ ���� �ٲ�� �� �־��ֱ�

        Transform parent = uiparent.transform;
        var Tops = ItemManager.Instance.Tops;

        for (int i = 0; i < Tops.Count; i++)
        {
            var top = Tops[i];
            for (int itemIdx = 0; itemIdx < top.Idx; i++)
            {
                GameObject ui = Instantiate(itemUI, parent);
                uiPool[itemIdx] = ui;

            }
        }
    }


}
