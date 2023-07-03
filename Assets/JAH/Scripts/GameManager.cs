using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 역할 1: 게임 처음 시작할때 객체,UI들을 Instansiate
// 역할 2: 캐릭터 데이터 저장, 로드
// - 캐릭터 이름값
// - 캐릭터 모델

public class GameManager : MonoBehaviour
{
    // - 캐릭터 이름 저장값
    public TMP_InputField inputName;
    // - 싱글톤으로 관리
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    // 역할 2: 캐릭터 데이터를 저장
    public void Save()
    {
        Debug.Log("작동!  Save" + inputName.text);
        // 캐릭터 이름 값을 저장함
        PlayerPrefs.SetString("Name", inputName.text);
        // 캐릭터 각각에 Index 번호를 부여하는 스크립트를 만든다.
        // Index 번호를 PlayerPrefs를 통해 저장한다
        //PlayerPrefs.SetInt("Index" )

            // 각각 캐릭터 이름을 "Character + Index" 로 정하고 Resoruces 에 프리팹으로 저장
        // --> 프리팹으로 저장!

    }

    // 역할 2: 캐릭터 데이터 로드
    public void Load()
    {
        Debug.Log("작동2! Load");
        if (PlayerPrefs.HasKey("Name"))
        {
            Debug.Log("작동2!" + PlayerPrefs.GetString("Name"));
            inputName.text = PlayerPrefs.GetString("Name");
            // 캐릭터의 인덱스 번호를 불러온다
            // 인스턴시에이트!(character + index )
         
        }
    }

}
