using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� 1 : �̸��� �Է��ϰ� ���͸� ������ Ŀ���� UI ����
// - Ŀ���� UI
// ���� 2:  ī�޶� UI ����
// - ī�޶� UI

public class NameEnter : MonoBehaviour
{
    // - Ŀ���� UI
    public GameObject customUI;
    // - ī�޶� UI
    public GameObject cameraUI;

    public void NameInput()
    {
        // ���� 1 : �̸��� �Է��ϰ� ���͸� ������ Ŀ���� UI ����
        Destroy(customUI);
        // ���� 2:  ī�޶� UI ����
        cameraUI.gameObject.SetActive(true);
    }
}
