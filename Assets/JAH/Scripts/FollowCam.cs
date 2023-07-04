using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� 1 : ĳ���Ͱ� ķ�� ����ٴѴ�
public class FollowCam : MonoBehaviour
{
    // ������ Ÿ��
    public Transform target;
    // ī�޶� ���� ���� �Ÿ�
    public float dist = 10f;
    // ĳ������ ���� ����
    public float height = 1;
    // �ε巯�� ȸ���� ���� ����
    public float smoothRoate = 5f;

    // ĳ���� �ڽ��� ����
    private Transform tr;

    private void Start()
    {
        tr = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        // �ε巯�� ȸ���� ���� Mathf. LerpAngle
        float currYAngle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, smoothRoate * Time.deltaTime);

        // ���Ϸ� Ÿ���� ���ʹϾ����� �ٲٱ�
        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);

        // ĳ������ ��ġ�� Ÿ�� ȸ�� ������ŭ ȸ�� �� dist��ŭ ����, ���̸� �ø���
        tr.position = target.position + (target.forward * dist) + (Vector3.up * height);

        // Ÿ���� �ٶ󺸰� �ϱ�
        tr.LookAt(target);
    }
}
