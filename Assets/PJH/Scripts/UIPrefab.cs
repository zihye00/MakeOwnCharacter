using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����տ� ���;��ϴ� ���� �����ϱ�
// ���� �޾ƿ���?

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
