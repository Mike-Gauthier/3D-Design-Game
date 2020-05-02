using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRail : Rail
{


    public float XDirection;

    public float ZDirection;

    public float XRotation;

    public float ZRotation;

    public float YRotation;



    public override Vector3 RailPosition()
    {
        return new Vector3(XDirection, 0, ZDirection);  //reminder to remove public variables
    }
    public override Quaternion RailRotation()
    {
        return new Quaternion(XRotation, YRotation, ZRotation, 0);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
