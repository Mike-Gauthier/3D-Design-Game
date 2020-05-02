using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRail : Rail
{
    public float XDirection;
    
    public float ZDirection;

    public override Vector3 RailPosition()
    {
        return new Vector3(XDirection, 0, ZDirection);  //reminder to remove public variables
    }
    public override Quaternion RailRotation()
    {
        return new Quaternion(0, 0, 0, 0);
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
