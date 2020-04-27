using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    public float timer;
    public float chance;
    public GameObject obstacles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0)
        {
            chance = Random.Range(1, 10);
            if(chance < 5)
            {
                Instantiate(obstacles, transform.position, transform.rotation);
            }
            else { }
            timer = 10.0f;
        }

    }
}
