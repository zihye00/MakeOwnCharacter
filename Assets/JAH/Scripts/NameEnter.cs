using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

// ���� 1 : �̸��� �Է��ϰ� ���͸� ������ Ŀ���� UI ����
// - Ŀ���� UI

// ���� 2:  ī�޶� UI ����
// - ī�޶� UI

// ���� 3 : Midair�νı⸦ �����
// - Midair�ν�

// ���� 4 : ���� ��ư�� ����
// - �����ư
public class NameEnter : MonoBehaviour
{
    // - Ŀ���� UI
    public GameObject customUI;
    // - ī�޶� On ��ư
    public GameObject OnBtn;
    // - Midair�ν�
    public GameObject midairFinder;


    public void NameInput()
    {
        // ���� 1 : �̸��� �Է��ϰ� ���͸� ������ Ŀ���� UI ����
        Destroy(customUI);

        // ���� 2:  ī�޶� UI ����
        OnBtn.gameObject.SetActive(true);

        // ���� 3 : Midair�νı⸦ �����
        // Plan Finder�� ��Ŀ������������ Ground Plan Stage ����
        MidAirPositionerBehaviour.Destroy(midairFinder);

    }
}
