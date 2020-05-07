using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class BellRing : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    AudioSource bellRing;

    void Start()
    {
        bellRing = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Train Collide");
            myAnimationController.SetBool("playRing", true);
            bellRing.Play();
        }
    }

    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("playRing", false);
        }
    }*/
}
