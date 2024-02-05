
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ffff : MonoBehaviour
{
    [HideInInspector] public GameObject col;
    public Texture tx;
    public Texture ty;      //Kaftosha

    public void Spawf()
    {
        col.GetComponent<Renderer>().material.mainTexture = ty;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("ground")) {
            col = collision.gameObject;
            col.GetComponentInChildren<Renderer>().material.mainTexture = tx;

        }
    }
  
}
