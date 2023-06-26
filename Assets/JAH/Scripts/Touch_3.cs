using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_3 : MonoBehaviour
{
    // - ĳ����1
    public GameObject character_1;
    // - ĳ����2
    public GameObject character_2;
    // - ĳ����4
    public GameObject character_4;


    // ���� 1 : Character_1(�� �ڽ�)�� ��ġ�ϸ� �� �ڽŸ� Ȱ��ȭ
    public void Touch()
    {
        // ��ġ���� ������ ����X
        if (Input.touchCount == 0) return;

        // ù ��° ��ġ ���� �ҷ�����
        Touch touch = Input.GetTouch(0);

        // Choose img_1(�� �ڽ�)�� ��ġ�ϸ� ĳ������3 �� Ȱ��ȭ
        if (touch.phase == TouchPhase.Began)
        {
            // if(ĳ���� 1�� ��ġ�ϸ�)
            // - ������ ��Ȱ��ȭ
            Destroy(character_1);
            Destroy(character_2);
            Destroy(character_4);

        }
    }
}
