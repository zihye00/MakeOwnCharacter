using System.Collections.Generic;
using UnityEngine;

// 프리팹에 나와야하느 정보 저장하기
// 정보 받아오기?

public class UIPrefab : MonoBehaviour
{
    [SerializeField]
    public string name;
    [SerializeField]
    public GameObject image;
    [SerializeField]
    public int characterIdx;
    [SerializeField]
    public int itemIdx;
    [SerializeField]
    public string buttonName;

    List<GameObject> customHat = new List<GameObject>();
    List<GameObject> customTop = new List<GameObject>();
    List<GameObject> customBottom = new List<GameObject>();
    List<GameObject> customShoes = new List<GameObject>();

    List<GameObject> basicRobot = new List<GameObject>();

    private void Start()
    {
        customHat = CharacterIndexInit.Instance.Hat;
        customTop = CharacterIndexInit.Instance.Top;
        customBottom = CharacterIndexInit.Instance.Bottom;
        customShoes = CharacterIndexInit.Instance.Shoes;
        basicRobot = CharacterIndexInit.Instance.Basic;
    }

    public void OnClickUI()
    {
        buttonName = CheckIndex.Instance.bottonName;
        characterIdx = CheckIndex.Instance.characterIndex;

        if (buttonName == "Hat")
        {
            BGMManager.Instance.OnTouchButton();

            for (int i = 0; i < 32; i++)
            {

                if (customHat[i].transform.name == name)
                {
                    if (characterIdx == 1)
                    {
                        basicRobot[0].gameObject.SetActive(false);

                    }
                    if (characterIdx == 0)
                    {
                        basicRobot[4].gameObject.SetActive(false);

                    }

                    customHat[i].gameObject.SetActive(true);
                    EffectManager.Instance.PlayParticleSystem();

                }
                else
                {

                    customHat[i].gameObject.SetActive(false);
                    EffectManager.Instance.PlayParticleSystem();

                }
            }


        }
        if (buttonName == "Top")
        {
            BGMManager.Instance.OnTouchButton();


            for (int i = 0; i < 32; i++)
            {

                if (customTop[i].transform.name == name)
                {
                    if (characterIdx == 1)
                    {
                        basicRobot[1].gameObject.SetActive(false);
                    }
                    customTop[i].gameObject.SetActive(true);
                    EffectManager.Instance.PlayParticleSystem();

                }
                else
                {
                    customTop[i].gameObject.SetActive(false);
                    EffectManager.Instance.PlayParticleSystem();

                }
            }


        }
        if (buttonName == "Bottom")
        {
            BGMManager.Instance.OnTouchButton();


            for (int i = 0; i < 32; i++)
            {
                if (customBottom[i].transform.name == name)
                {
                    if (characterIdx == 1)
                    {
                        basicRobot[2].gameObject.SetActive(false);
                    }
                    customBottom[i].gameObject.SetActive(true);
                    EffectManager.Instance.PlayParticleSystem();

                }
                else
                {

                    customBottom[i].gameObject.SetActive(false);
                    EffectManager.Instance.PlayParticleSystem();

                }
            }


        }
        if (buttonName == "Shoes")
        {

            BGMManager.Instance.OnTouchButton();


            for (int i = 0; i < 32; i++)
            {
                if (customShoes[i].transform.name == name)
                {
                    if (characterIdx == 1)
                    {
                        basicRobot[3].gameObject.SetActive(false);
                    }
                    customShoes[i].gameObject.SetActive(true);
                    EffectManager.Instance.PlayParticleSystem();

                }
                else
                {
                    customShoes[i].gameObject.SetActive(false);
                    EffectManager.Instance.PlayParticleSystem();

                }
            }

        }

        //EffectManager.Instance.PlayParticleSystem();

    }
}