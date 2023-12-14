using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ncoll : MonoBehaviour
{
    public GameObject colvrog;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<vrogi>(out vrogi vro))
        {
            colvrog=vro.gameObject;
           // Destroy(collision.gameObject);

        }
    }
}