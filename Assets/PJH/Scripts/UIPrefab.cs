using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 프리팹에 나와야하느 정보 저장하기
// 정보 받아오기?

public class UIPrefab : MonoBehaviour
{
    [SerializeField]
    public string name;
    [SerializeField]
    public GameObject image;
    [SerializeField]
    public int characterIdx;
    [SerializeField]
    public int itemIdx;

    private List<ItemManager> items = new List<ItemManager>();

    private void Start()
    {

    }

}
