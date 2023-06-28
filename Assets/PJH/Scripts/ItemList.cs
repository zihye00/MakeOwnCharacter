using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// hat, top, bottom, shoes
// class를 List?로 꺼내면 될까?

public class ItemList : MonoBehaviour
{
    public List<Top> tops;

    private void Start()
    {
        tops.Insert(0, new Top() { name = "Top0A", image = Resources.Load<Sprite>("Prefab/Top0A"), idx = 0 });
        tops.Insert(1, new Top() { name = "Top0B", image = Resources.Load<Sprite>("Prefab/Top0B"), idx = 0 });
        tops.Insert(2, new Top() { name = "Top1A", image = Resources.Load<Sprite>("Prefab/Top1A"), idx = 1 });
        tops.Insert(3, new Top() { name = "Top1B", image = Resources.Load<Sprite>("Prefab/Top1B"), idx = 1 });
        tops.Insert(4, new Top() { name = "Top2A", image = Resources.Load<Sprite>("Prefab/Top2A"), idx = 2 });
        tops.Insert(5, new Top() { name = "Top2B", image = Resources.Load<Sprite>("Prefab/Top2B"), idx = 2 });
        tops.Insert(6, new Top() { name = "Top3A", image = Resources.Load<Sprite>("Prefab/Top3A"), idx = 3 });
        tops.Insert(7, new Top() { name = "Top3B", image = Resources.Load<Sprite>("Prefab/Top3B"), idx = 3 });
    }


}



