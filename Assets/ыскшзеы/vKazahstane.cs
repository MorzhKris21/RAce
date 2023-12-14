using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vKazahstane : VseProVse
{
    public vKazahstane(dataCentr dnd) : base(dnd)
    {
    }
    public override void Vhod()
    {
        dC.v3 = new(dC.v3.x, dC.sprig, dC.v3.z);

    }

    public override void Hod()
    {

        metodotvechaetzadvizhenie();
        zatrans();
        lichiko();
        graviy(2);
        if (!dC.chara.isGrounded)
        {
            dC.uprig();
        }
    }

    public override void Uhod()
    {



    }
}
