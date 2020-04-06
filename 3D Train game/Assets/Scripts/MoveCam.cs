using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public float speed = 1;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f * Time.deltaTime * speed, 5f * Time.deltaTime * speed, 0f * Time.deltaTime);
    }
}
