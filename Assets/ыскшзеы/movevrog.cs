using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movevrog : nechistbase
{
    public movevrog(vrogi vrig) : base(vrig)
    {
    }
    public override void Vhod()
    {
    }
    public override void Hod()
    {
        dvizhenienechisti(vr.kg.transform.position);
    }
    public override void Uhod()
    {
        
    }
}
