using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameChanger : MonoBehaviour
{

    public GameObject leftRail;
    public GameObject leftRailKey;
    public GameObject centerRail;
    public GameObject centerRailKey;
    public GameObject rightRail;
    public GameObject rightRailKey;

    // Start is called before the first frame update
    void Start()
    {
        rightRail.SetActive(false);
        rightRailKey.SetActive(false);
        centerRail.SetActive(true);
        centerRailKey.SetActive(true);
        leftRail.SetActive(false);
        leftRailKey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            rightRail.SetActive(true);
            rightRailKey.SetActive(true);
            centerRail.SetActive(false);
            centerRailKey.SetActive(false);
            leftRail.SetActive(false);
            leftRailKey.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rightRail.SetActive(false);
            rightRailKey.SetActive(false);
            centerRail.SetActive(true);
            centerRailKey.SetActive(true);
            leftRail.SetActive(false);
            leftRailKey.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rightRail.SetActive(false);
            rightRailKey.SetActive(false);
            centerRail.SetActive(false);
            centerRailKey.SetActive(false);
            leftRail.SetActive(true);
            leftRailKey.SetActive(true);
        }
    }
}
