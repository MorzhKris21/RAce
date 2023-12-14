using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vZaculise : VseProVse
{
    public vZaculise(dataCentr dnd) : base(dnd)
    {
    }
    public override void Vhod()
    {
        dC.v3.y = 0;

    }
    public void urig()
    {
        dC.states(new nedvigoetsya(dC));

    }

    public override void Hod()
    {

        metodotvechaetzadvizhenie();
        zatrans();
        lichiko();
        graviy(44);
        if (dC.chara.isGrounded)
        {
            urig();
        }
        if (dC.transform.position.y < -100)
        {
            SceneManager.LoadScene("Prototype 1");

        }
    }

    public override void Uhod()
    {

    }
}
