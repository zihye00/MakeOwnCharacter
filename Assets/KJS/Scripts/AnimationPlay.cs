using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{    

    public enum AnimeState
    {
        IDLE,
        Hi,
    }

    // Animator
    public Animator[] anim;

    // Start is called before the first frame update
    void Start()
    {

    }

   

   

    public void Idle()
    {

        

        // + Animation 상태를 Idle 로 변경
        anim[0].SetTrigger("IDLE");
        anim[1].SetTrigger("IDLE");
        anim[2].SetTrigger("IDLE");
        anim[3].SetTrigger("IDLE");

    }

    
    public void Hi()
    {
        // + Animation 상태를 HI 로 변경
        anim[0].SetTrigger("HI"); 
        anim[1].SetTrigger("HI");
        anim[2].SetTrigger("HI");
        anim[3].SetTrigger("HI");


    }

    
}
