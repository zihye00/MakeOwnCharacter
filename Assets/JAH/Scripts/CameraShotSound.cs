using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShotSound : MonoBehaviour
{
    public static CameraShotSound Instance;

    private AudioSource shotEffect;

    private void Awake()
    {
        shotEffect = GetComponent<AudioSource>();
    }

    public void CameraEffectSound()
    {
        shotEffect.Stop();
        shotEffect.Play();
    }

}
