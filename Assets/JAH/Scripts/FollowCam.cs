using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 역할 1 : 캐릭터가 캠을 따라다닌다
public class FollowCam : MonoBehaviour
{
    // 추적할 타겟
    public Transform target;
    // 카메라 와의 일정 거리
    public float dist = 10f;
    // 캐릭터의 높이 설정
    public float height = 1;
    // 부드러운 회전을 위한 변수
    public float smoothRoate = 5f;

    // 캐릭터 자신의 변수
    private Transform tr;

    private void Start()
    {
        tr = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        // 부드러운 회전을 위한 Mathf. LerpAngle
        float currYAngle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, smoothRoate * Time.deltaTime);

        // 오일러 타입을 쿼터니언으로 바꾸기
        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);

        // 캐릭터의 위치를 타겟 회전 각도만큼 회전 후 dist만큼 띄우고, 높이를 올리기
        tr.position = target.position + (target.forward * dist) + (Vector3.up * height);

        // 타겟을 바라보게 하기
        tr.LookAt(target);
    }
}
