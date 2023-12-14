using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VseProVse : stateSanya
{
    public dataCentr dC;
    public VseProVse(dataCentr dnd)
    {
        dC = dnd;
    }

    public void graviy(int gravmod)
    {
        if(dC.v3.y > Physics.gravity.y)
        {
            dC.v3.y += Physics.gravity.y*gravmod*Time.deltaTime;
        }
    }
    protected void zatrans()
    {
        Vector3 forwar = new(dC.trans.forward.x,0,dC.trans.forward.z);
        Vector3 righte = new(dC.trans.right.x, 0, dC.trans.right.z);
        Vector3 napravlenie = forwar.normalized * dC.novinochkaCC.actionsSklavoi.y + righte.normalized * dC.novinochkaCC.actionsSklavoi.x;
        dC.v3.z = napravlenie.z * dC.sped;
        dC.v3.x = napravlenie.x*dC.sped;

    }
    protected void lichiko()
    {
        Vector3 lichpravlenie = new(dC.v3.x, 0, dC.v3.z);
        if(lichpravlenie==Vector3.zero )
        {
            return;
        }
        dC.transform.rotation = Quaternion.Slerp(dC.transform.rotation,Quaternion.LookRotation(lichpravlenie),dC.naspedah*Time.deltaTime);
    }
    

    protected void metodotvechaetzadvizhenie()
    {
        dC.chara?.Move(dC.v3*Time.deltaTime);
    } 
    public override void Hod()
    {
    }

    public override void Uhod()
    {
    }

    public override void Vhod()
    {
    }
}
