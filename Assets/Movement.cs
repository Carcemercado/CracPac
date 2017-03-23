using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float magnitude = 1;
    // Use this for initialization
    void Start()
    {

    }

    void ProcessInput()
    {
        Vector3 force = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            force += new Vector3(0, 0, magnitude);
        }

        if (Input.GetKey(KeyCode.S))
        {
            force += new Vector3(0, 0, -magnitude);
        }

        if (Input.GetKey(KeyCode.A))
        {
            force += new Vector3(-magnitude, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            force += new Vector3(magnitude, 0, 0);

        }

	
        gameObject.GetComponent<Rigidbody>().AddForce(force);
	
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }
}
