using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ьщму : MonoBehaviour
{
    private int speed=4;
    private int speed1=42;
    private float h;
    private float v;
    private Rigidbody rb;
    private int speed2=2;

    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }


    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * speed1*h*Time.deltaTime);
        transform.Translate(Vector3.forward * speed*v*Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * speed2, ForceMode.Impulse); 
        }

    }
}
