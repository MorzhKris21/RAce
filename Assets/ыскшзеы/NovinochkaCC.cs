using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class NovinochkaCC : MonoBehaviour,IA.IBUZZActions
{
    private IA oi;
    public Vector2 actionsSklavoi;
    public Action prigskok;
    private dataCentr dC;
    public bool isBuz;
    public CinemachineVirtualCamera camero;
    public GameObject buzdc;
    public GameObject chardc;



    private void OnEnable()
    {
        camero=FindObjectOfType<CinemachineVirtualCamera>();
        dC=GetComponent<dataCentr>();
        oi = new IA();
        oi.BUZZ.Enable();
        oi.BUZZ.SetCallbacks(this);
     
    }
    private void OnDisable()
    {
        oi.BUZZ.Disable();
    }
    public void OnDvizhenie(InputAction.CallbackContext context)
    {
        actionsSklavoi=oi.BUZZ.dvizhenie.ReadValue<Vector2>();
    }


    public void OnPrizok(InputAction.CallbackContext context)
    {
        prigskok?.Invoke();

    }

    public void OnOtok(InputAction.CallbackContext context)
    {

        for (int i = 0; i < dC.vrogis.Count; i++)
        {

            if (Vector3.Distance(dC.gameObject.transform.position, dC.vrogis[i].gameObject.transform.position) < 4)
            {
                dC.vrogis.Remove(dC.vrogis[i]);
                dC.states(new otok(dC));


            }
        }
    }
    public void BUZ()
    {
        isBuz = !isBuz;
        if (isBuz)
        {
            buzdc.SetActive(true);
            chardc.SetActive(false);
            camero.Follow = buzdc.gameObject.transform;
            camero.LookAt = buzdc.gameObject.transform;
        }
        else if(!isBuz)
        {
            buzdc.SetActive(false);
            chardc.SetActive(true);

            camero.Follow = chardc.gameObject.transform;
            camero.LookAt = chardc.gameObject.transform;
        }
    }

    public void OnTransmode(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            BUZ();
        }
        
    }

    public void OnKartofel(InputAction.CallbackContext context)
    {
        if (context.started && dC.Ff.col.CompareTag("ground"))
        {

            dC.Ff.Spawf();
        }
    }
}

