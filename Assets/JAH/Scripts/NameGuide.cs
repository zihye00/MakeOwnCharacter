using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameGuide : MonoBehaviour
{
    public GameObject nameui;

    public void NameGuideUI()
    {
        StartCoroutine(NameUI());
        Debug.Log("이름가이드");
    }

    IEnumerator NameUI()
    {
        nameui.SetActive(true);
        yield return new WaitForSeconds(2);
        nameui.SetActive(false);
    }
}
