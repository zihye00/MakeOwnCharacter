using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.Load();
    }

}
