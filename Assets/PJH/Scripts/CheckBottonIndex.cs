using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Hat, Top, Bottom, Shoes 버튼을 누를때 index 저장하기
public class CheckBottonIndex : MonoBehaviour
{

    public void OnClickHat()
    {
        CheckIndex.Instance.SetBottonIndex("Hat");
    }
    public void OnClickTop()
    {
        CheckIndex.Instance.SetBottonIndex("Top");
    }
    public void OnClickBottom()
    {
        CheckIndex.Instance.SetBottonIndex("Bottom");
    }
    public void OnClickShoes()
    {
        CheckIndex.Instance.SetBottonIndex("Shoes");
    }
}
