
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ffff : MonoBehaviour
{
    public GameObject col;
    public Texture tx;
    public Texture ty;      //Kaftosha



    void Start()
    {

    }

    void Update()
    {

    }
    public void Spawf()
    {
        col.GetComponent<Renderer>().material.mainTexture = ty;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("ground")) {
            col = collision.gameObject;
            collision.gameObject.GetComponent<Renderer>().material.mainTexture = tx;
        }
    }
  
}
