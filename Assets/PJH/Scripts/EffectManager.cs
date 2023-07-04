using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static EffectManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public List<ParticleSystem> effect;

    public void PlayParticleSystem()
    {
        int characterIdx = CheckIndex.Instance.characterIndex;


            if (characterIdx == 0)
            {

                effect[0].Play();
            }
            if (characterIdx == 1)
            {

                effect[1].Play();
            }
            if (characterIdx == 2)
            {

                effect[2].Play();
            }
            if (characterIdx == 3)
            {

                effect[3].Play();
            }
    }
}
