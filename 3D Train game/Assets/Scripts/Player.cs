using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float XDirection = 0;
    public float YDirection = 15;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement section

        if (Input.GetKey("a"))
        {
            print("Left");
            YDirection = 0;
            XDirection = -15;
            

            //transform.Translate(XDirection * Time.deltaTime * speed, 0f, 0f);
        }
        if (Input.GetKey("w"))
        {
            print("Up");

            YDirection = 15;
            XDirection = 0;

            //transform.Translate(0f, 0f, YDirection * Time.deltaTime * speed);
        }
        if (Input.GetKey("d"))
        {
            print("Right");

            YDirection = 0;
            XDirection = 15;

            //transform.Translate(XDirection * Time.deltaTime * speed, 0f, 0f);
        }
        if (Input.GetKey("s"))
        {
            print("Down");

            YDirection = -15;
            XDirection = 0;

            //transform.Translate(0f, 0f, -15f * Time.deltaTime * speed);
        }
        transform.Translate(XDirection * Time.deltaTime * speed, 0f, YDirection * Time.deltaTime * speed);



        //transform.Translate(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, 0f, Input.GetAxisRaw("Vertical") * Time.deltaTime * speed);
    }
}
