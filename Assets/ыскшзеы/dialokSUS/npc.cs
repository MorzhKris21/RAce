using Ink.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class npc : MonoBehaviour
{
    private dialok dial;
    private dataCentr dC;
    private void Start()
    {
        dial=FindObjectOfType<dialok>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<dataCentr>(out dataCentr chara))
        {
            dC = FindObjectOfType<dataCentr>();
            dC.detectNPC = gameObject;
            dial.ContinueStory();
            GetComponent<Collider>().enabled= false;
        }
    }

    void Update()
    {
        
    }
}
