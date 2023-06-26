using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간 마다 랜덤하게 오브젝트를 생성한다
// 시간 변수
// - 랜덤 범위 : 오브젝트 수 (리스트)
// - 각각의 오브젝트 프리팹으로 관리
public class RandomActive : MonoBehaviour
{
    // 시간 변수
    private float currentTime;
    // 랜덤하게 생성할 오브젝트 
    public List<GameObject> objectspref = new List<GameObject>();
    private void Update()
    {
        // 시간이 흐른다
        currentTime += Time.deltaTime;
        // 시간의 흐름에 따른 랜덤 생성
        ActiveObject();
    }
    public void ActiveObject()
    {
        // 시간이 10초를 경과하면
        if (currentTime > 1)
        {
            // 리스트 안의 오브젝트 중 하나를 랜덤으로 활성화 한다
            // 1. 랜덤으로 고르기 
            int selection = Random.Range(0, objectspref.Count);
            GameObject selectedPrefab = objectspref[selection];

            // 2. 위치 설정 
            Vector3 Pos = new Vector3(0, 0, 0);
            // 3. 선택된 오브젝트 Instansiate
            Instantiate(selectedPrefab, Pos, Quaternion.identity);

            // 4. 시간 초기화
            currentTime = 0;

        }
    }
}
