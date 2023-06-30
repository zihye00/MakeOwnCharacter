using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����տ� ���;��ϴ� ���� �����ϱ�
// ���� �޾ƿ���?

public class UIPrefab : MonoBehaviour
{
    [SerializeField]
    private string name;
    [SerializeField]
    private GameObject image;
    [SerializeField]
    private int characterIdx;
    [SerializeField]
    private int itemIdx;

    private List<ItemManager> items = new List<ItemManager>();

    private void Start()
    {
        image = CheckIndex.Instance.image;
        characterIdx = CheckIndex.Instance.characterIndex;
        itemIdx = CheckIndex.Instance.itemIdx;
    }

}
