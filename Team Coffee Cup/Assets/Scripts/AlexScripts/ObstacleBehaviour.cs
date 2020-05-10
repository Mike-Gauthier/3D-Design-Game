using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleBehaviour : MonoBehaviour
{
    public GameObject player;

    public GameObject gameOverFrame;

    AudioSource crashSound;

    public bool hasCrashed;
    public string mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        crashSound = GetComponent<AudioSource>();
        gameOverFrame = GameObject.FindGameObjectWithTag("GameOver");
        gameOverFrame.transform.localScale = new Vector3(0, 0, 0);
        hasCrashed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Train Crash");
            hasCrashed = true;
            crashSound.Play();
            player.GetComponent<AIfollow>().enabled = false; //Removes AI follow script for now, can be replaced for better optimization
            //Put crash animation here
            gameOverFrame.transform.localScale = new Vector3(5, 5, 5);
        }
    }
}
