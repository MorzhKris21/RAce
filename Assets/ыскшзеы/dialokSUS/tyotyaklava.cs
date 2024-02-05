using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class tyotyaklava : MonoBehaviour, IA.IDialogesustimActions
{
    private IA oi;
    public dialok dial;

    public void OnSledush(InputAction.CallbackContext context)
    {
        if (context.canceled && dial.currentchoices.Count <= 0)
        {
            Debug.Log("nyanur");
            dial.ContinueStory();
        }
    }

    void OnEnable()
    {
        /*if (oi != null)
        {
          return;
        }*/
        oi = new IA();
        oi.dialogesustim.Enable();
        oi.dialogesustim.SetCallbacks(this);
    }

    void OnDisable()
    {
        oi.dialogesustim.Disable();
    }
}
