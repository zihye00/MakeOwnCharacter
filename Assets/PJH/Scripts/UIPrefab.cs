using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 프리팹에 나와야하느 정보 저장하기
// 정보 받아오기?

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
