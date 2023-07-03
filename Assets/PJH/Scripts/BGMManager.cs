using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static BGMManager Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    public AudioSource bgm;

    public AudioSource touchSound;

    public void OnTouchButton()
    {
        touchSound.Play();
        //touchSound.Stop();
    }
    
}
