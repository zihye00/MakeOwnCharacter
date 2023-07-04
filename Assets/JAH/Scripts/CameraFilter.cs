using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFilter : MonoBehaviour
{
    public ParticleSystem starFilter;

        public void StarFilter()
    {
        starFilter.Stop();
        starFilter.Play();
    }

    public void FilterStop()
    {
        starFilter.Stop(); 
    }
}
