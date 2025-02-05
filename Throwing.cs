using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    public Rigidbody rb;
    private int forward = 0;
    private int up = 0;
    private bool Air;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Air = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(forward);
        if (forward > 0)
        {
            forward--;
        }

        if (up > 0)
        {
            up--;
        }
        

       if (Input.GetMouseButtonDown(0) && !Air)
        {
            forward = 2;
            up = 5;
            Air = true;
            rb.velocity = new Vector3(forward, 7, 0);

        }
       
        //rb.velocity = new Vector3(forward, up, 0);


    }

    private void OnCollisionEnter(Collision collision)
    {
        Air = false;
        Debug.Log("Object collided with the ground");

    }
}
