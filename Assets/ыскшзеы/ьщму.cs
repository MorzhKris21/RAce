using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ьщму : MonoBehaviour
{
    public int speed=4;
    public int speed1=42;
    public float h;
    public float v;
    public Rigidbody rb;

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
            rb.AddForce(Vector3.up * speed, ForceMode.Impulse); 
        }

    }
}
