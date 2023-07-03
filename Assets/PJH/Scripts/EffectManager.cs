using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static EffectManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public ParticleSystem effect;

    public void PlayParticleSystem()
    {
        effect.Play();
        effect.Stop();
    }

}
