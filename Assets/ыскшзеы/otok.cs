using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class otok : VseProVse {



    public otok(dataCentr dnd) : base(dnd)
    {
    }
    public override void Vhod()
    {


        dC.cou.chCount(1);
        if (dC.Nc.colvrog != null)
        {
            MonoBehaviour.Destroy(dC.Nc.colvrog.gameObject);
        }
    }
    public override void Hod()
    {

        dC.states(new nedvigoetsya(dC));


    }
    public override void Uhod()
    {

    }
}
