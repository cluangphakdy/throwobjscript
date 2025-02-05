using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    public Rigidbody rb;
    private int forward = 0;
    private int up = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
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
        

       if (Input.GetMouseButtonDown(0))
        {
            forward = 2;
            up = 5;
            rb.velocity = new Vector3(forward, 5, 0);

        }
        //rb.velocity = new Vector3(forward, up, 0);


    }
}
