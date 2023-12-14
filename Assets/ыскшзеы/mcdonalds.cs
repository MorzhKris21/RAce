using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mcdonalds : MonoBehaviour
{
    public GameObject gmO;
    public int randx;
    public int randy;
    public int randz;

    void Start()
    {
        InvokeRepeating("spw", 4, 4);
    }

    void spw()
    {
        randx = Random.Range(-200, -80);
        randy = Random.Range(0, 1);
        randz = Random.Range(-20, -40);
        Instantiate(gmO,new Vector3(randx, randy, randz),Quaternion.identity);
    }
}
