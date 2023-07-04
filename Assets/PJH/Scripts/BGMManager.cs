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

    private void Start()
    {
        OnStartBGM();
    }

    public List<AudioClip> bgm;
    public AudioSource bgmAudioSource;

    public AudioSource touchSound;

    public void OnTouchButton()
    {
        touchSound.Play();
        //touchSound.Stop();
    }

    public void OnStartBGM()
    {
        bgmAudioSource.clip = bgm[0];
        bgmAudioSource.Play();
    }

    public void OnStartCameraMusic()
    {
        bgmAudioSource.clip = bgm[1];
        bgmAudioSource.Play();
    }
    public void OnStartBasicMusic()
    {
        if (bgmAudioSource.clip == bgm[1])
        {
            bgmAudioSource.clip = bgm[0];
            bgmAudioSource.Play();
        }
    }

}
