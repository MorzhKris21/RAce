using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialog : MonoBehaviour
{
    private TextMeshProUGUI di;
    private string[] tetatet = { "tuuuuuuuuu", "Картофка","Неть врогам норода.","Мяу." };



    void OnEnable()
    {
        di=GetComponent<TextMeshProUGUI>();
        InvokeRepeating("randomiz",0,1);
    }
    void randomiz()
    {
        int a = Random.Range(0,tetatet.Length-1);
        di.text= tetatet[a];
    }
    private void OnDisable()
    {
        CancelInvoke("randomiz");
    }
}
