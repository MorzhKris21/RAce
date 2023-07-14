using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ffff : MonoBehaviour
{
    public GameObject ff;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
           
        }
    }
    void Spawf()
    {
       Debug.Log("Ne hodi po moim gryadkam.");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground")) {
            Spawf();
        }
    }
}
