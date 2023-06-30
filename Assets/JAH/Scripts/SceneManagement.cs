using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ���� : �� �̵��� ����

public class SceneManagement : MonoBehaviour
{
    // StartScene���� GameStart ��ư�� ������ Lobby������ �̵�
    public void  SceneLoadToLobby()
    {
        SceneManager.LoadScene("LobbyScene");
    }

    // LobbyScene���� MY Friends ��ư�� ������ ������̵�
    public void SceneLoadToSave()
    {
        SceneManager.LoadScene("SaveScene");
    }

    // LobbyScene���� Make Friend ��ư�� ������ ���ξ��̵�
    public void SceneLoadToMain()
    {
        SceneManager.LoadScene("NameCamera");
    }

}
