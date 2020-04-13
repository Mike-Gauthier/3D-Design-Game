using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject[] spots;
    public int length;
    bool isAtMax = false;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        length = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //cycles through camera positions

        if(Input.GetKeyDown(KeyCode.E) && isAtMax == false)
        {
            Debug.Log("Camera Switch Up");
            mainCamera.transform.position = spots[length].transform.position;
            mainCamera.transform.rotation = spots[length].transform.rotation;
            length += 1;
            if(length >= spots.Length)
            {
                isAtMax = true;
            }
        }
        if (Input.GetKey(KeyCode.E) && isAtMax == true)
        {
            Debug.Log("Camera Switch Down");
            length -= 1;
            mainCamera.transform.position = spots[length].transform.position;
            mainCamera.transform.rotation = spots[length].transform.rotation;
            
            if (length <= 0)
            {
                isAtMax = false;
            }
        }
    }
}
