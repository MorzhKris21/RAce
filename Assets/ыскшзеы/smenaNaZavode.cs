using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class smenaNaZavode : MonoBehaviour
{

    private stateSanya sanya;


    public void states(stateSanya s)
    {
        sanya?.Uhod();
        sanya = s; 
        sanya.Vhod();
    }




    void FixedUpdate()
    {
        sanya?.Hod();
    }
}
