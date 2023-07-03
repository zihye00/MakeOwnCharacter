using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hat, Top, Bottom, Shoes 버튼을 누를때 index 저장하기
public class CheckBottonIndex : MonoBehaviour
{

    public string[] bottonName = new string[4] { "Hat", "Top", "Bottom", "Shoes" };

    public void OnClickHat()
    {
        BGMManager.Instance.OnTouchButton();
        CheckIndex.Instance.SetBottonIndex("Hat");
        CheckIndex.Instance.SetUIFromDictionary();
        UIManager.Instance.AddDeactiveUI();
        UIManager.Instance.MoveToUIParent();
    }
    public void OnClickTop()
    {
        BGMManager.Instance.OnTouchButton();
        CheckIndex.Instance.SetBottonIndex("Top");
        CheckIndex.Instance.SetUIFromDictionary();
        UIManager.Instance.AddDeactiveUI();
        UIManager.Instance.MoveToUIParent();

    }
    public void OnClickBottom()
    {
        BGMManager.Instance.OnTouchButton();
        CheckIndex.Instance.SetBottonIndex("Bottom");
        CheckIndex.Instance.SetUIFromDictionary();
        UIManager.Instance.AddDeactiveUI();
        UIManager.Instance.MoveToUIParent();

    }
    public void OnClickShoes()
    {
        BGMManager.Instance.OnTouchButton();
        CheckIndex.Instance.SetBottonIndex("Shoes");
        CheckIndex.Instance.SetUIFromDictionary();
        UIManager.Instance.AddDeactiveUI();
        UIManager.Instance.MoveToUIParent();


    }
}
