using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonEkshan : MonoBehaviour
{
    public dialok dia;
    private Button baton; 
    public int indecksfotalnyii;


    void OnEnable()
    {
        dia= FindObjectOfType<dialok>();
        baton= GetComponent<Button>();
        baton.onClick.AddListener(tetttete);
        
    }

    void tetttete()
    {
        dia.BatonEkshn(indecksfotalnyii);
    }
}
