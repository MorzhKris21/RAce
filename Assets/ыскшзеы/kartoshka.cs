using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class kartoshka : MonoBehaviour
{
    private int countkartofel = 0;
    private TextMeshProUGUI tmpgk;


    private void Start()
    {
        tmpgk = GetComponent<TextMeshProUGUI>();
    }
    public void kartofel(int changeValue)
    {
        countkartofel += changeValue;
        tmpgk.text = countkartofel.ToString();
    }
}

