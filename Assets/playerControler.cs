using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    public float zSpeed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position +=  new Vector3(0,0,zSpeed);
            transform.Translate(0, 0, zSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.position +=  new Vector3(0,0,zSpeed);
            transform.Translate(0, 0, -zSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, rotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }

    }
}
