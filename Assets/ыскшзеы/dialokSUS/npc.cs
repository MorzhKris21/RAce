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
    [SerializeField] private npcType type;
    public npcType Type => type;
    private void Start()
    {
        dial=FindObjectOfType<dialok>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<dataCentr>(out dataCentr chara))
        {
            chara.detectNPC = gameObject;
            Debug.Log(gameObject);
            GetComponent<Collider>().enabled = false;
            dial.ContinueStory();
        }
    }

}
