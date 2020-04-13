using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIfollow : MonoBehaviour
{
    /*
    //controls
    //change rail types
    public float xDirection = 0f;
    public float yDirection = 0f;
    public float zDirection = 2f;
    */

    
    /////
    public Vector3 OldPosition;

    ///public texts

    public Text RailTypeText;


    //list of rails

    public GameObject railstraight;
    public GameObject railleft;
    public GameObject railright;

    public GameObject CurrentRail;


    //Change rail
    public int Swaprail = 1;
    
    public LinkedList<GameObject> myLinkedList;
    //////
    public Transform target;
    public float speeed;
    GameObject actualRail;

    void Awake()
    {
        OldPosition = target.position;
        target = target.GetChild(0);
        Debug.Log("update");
        myLinkedList = new LinkedList<GameObject>();
        //actualRail = Instantiate(rail);
        
        
        print(myLinkedList.Count);
        
    }
    void Update()




    { //@TODO }

        

        if (Input.GetKeyDown("q"))
        {
            
            print("q");
            Swaprail = 0;
            //changes rail to 0 aka left turn
            CurrentRail = railleft;
            RailTypeText.text = "Rail in use: LEFT RAIL";
            print(RailTypeText);
        }

        if (Input.GetKeyDown("w"))
        {
            print("W");
            Swaprail = 1;
            //Changes rail to 1, aka straight rail
            CurrentRail = railstraight;
            RailTypeText.text = "Rail in use: STRAIGHT RAIL";
            print(RailTypeText);
        }

        if (Input.GetKeyDown("e"))
        {
            print("E");
            Swaprail = 2;
            //Changes rail to 2, aka right turn
            CurrentRail = railright;
            RailTypeText.text = "Rail in use: RIGHT RAIL";
            print(RailTypeText);
        }

        //button controls - to control which rail is being placed

      

        if (myLinkedList.Count !=0)
        {
            target = myLinkedList.Last.Value.transform;
        }


        ///////
        float step = speeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        ////Update movement
        
        if (Input.GetKeyDown("space"))
        {
            Vector3 newPosition = new Vector3(0, 0, 0);

            if (myLinkedList.Count != 0)
            {
                newPosition = myLinkedList.Last.Value.transform.parent.position + new Vector3(0, 0, 1);
            }
            else
            {
                newPosition = OldPosition + new Vector3(0, 0, 1); //Controls location of new rail. 
            }

            actualRail = Instantiate(CurrentRail, newPosition, CurrentRail.transform.rotation);
            myLinkedList.AddLast(actualRail.transform.GetChild(0).gameObject);
            print(myLinkedList.Count);
        }


    }
}
