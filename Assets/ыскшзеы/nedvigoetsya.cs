using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class nedvigoetsya : VseProVse
{
    private string b3="Blend Tree";
    private string parm2 = "Blend";




    public nedvigoetsya(dataCentr dnd):base(dnd) { 
    }
    public void prig()
    {
        dC.states(new vKazahstane(dC));

    }
    public override void Vhod()
    {
        dC.v3.y = Physics.gravity.y;
        dC.animator.CrossFadeInFixedTime(b3, 0.84f);
        dC.novinochkaCC.prigskok += prig;

    }
    public override void Hod()
    {
        zatrans();
        lichiko();
        metodotvechaetzadvizhenie();
        dC.animator.SetFloat(parm2, dC.novinochkaCC.actionsSklavoi.sqrMagnitude> 0 ? 1 : 0,0.84f,Time.deltaTime);
        if (!dC.chara.isGrounded)
        {
            dC.uprig();
        }
        dC.vrogis= MonoBehaviour.FindObjectsOfType<vrogi>().ToList(); 

    }
    public override void Uhod()
    {
        dC.novinochkaCC.prigskok -= prig;

    }

}
