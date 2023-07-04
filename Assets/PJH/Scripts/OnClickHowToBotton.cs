using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickHowToBotton : MonoBehaviour
{
    public GameObject howtoUI;
    public void OnClickHowto()
    {
        //howtoUI = Resources.Load<GameObject>("Prefab/HowToUI");
        //Instantiate(howtoUI);

        howtoUI.SetActive(true);
    }

    [System.Obsolete]
    public void OnClickX()
    {
        //DestroyObject(howtoUI);
        howtoUI.SetActive(false);
    }

}
