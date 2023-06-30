using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 역할 : 씬 이동을 관리

public class SceneManagement : MonoBehaviour
{
    // StartScene에서 GameStart 버튼을 누르면 Lobby씬으로 이동
    public void  SceneLoadToLobby()
    {
        SceneManager.LoadScene("LobbyScene");
    }

    // LobbyScene에서 MY Friends 버튼을 누르면 저장씬이동
    public void SceneLoadToSave()
    {
        SceneManager.LoadScene("SaveScene");
    }

    // LobbyScene에서 Make Friend 버튼을 누르면 메인씬이동
    public void SceneLoadToMain()
    {
        SceneManager.LoadScene("NameCamera");
    }

}
