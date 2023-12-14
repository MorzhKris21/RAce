using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nechistbase : stateSanya
{
    public vrogi vr;
    public nechistbase(vrogi vrig)
    {
        vr = vrig;
    }
    public void dvizhenienechisti(Vector3 povorotnagryadku)
    {
        vr.agent.SetDestination(povorotnagryadku);
    }
    public override void Hod()
    {
        throw new System.NotImplementedException();
    }

    public override void Uhod()
    {
        throw new System.NotImplementedException();
    }

    public override void Vhod()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {

    }

    void Update()
    {
        
    }
}
