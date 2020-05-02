using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    //have Matt call these variables and set them to true on instantiation
    Animator anim;
    bool isTurnLeft, isTurnRight, isCrashing = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isTurnLeft && isTurnRight && isCrashing != true)
        {
            anim.SetBool("TrainIdle", true);
        }
        else
        {
            anim.SetBool("TrainIdle", false);
        }

        if(isTurnLeft == true)
        {
            anim.SetBool("TrainLeft", true);
        }
        else
        {
            anim.SetBool("TrainLeft", false);
        }

        if (isTurnRight == true)
        {
            anim.SetBool("TrainRight", true);
        }
        else
        {
            anim.SetBool("TrainRight", false);
        }

        if (isCrashing == true)
        {
            anim.SetBool("TrainCrash", true);
        }
        else
        {
            anim.SetBool("TrainCrash", false);
        }
    }
}
