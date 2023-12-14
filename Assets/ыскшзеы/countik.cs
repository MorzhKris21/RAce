using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countik : MonoBehaviour
{

    public int count;
    public TextMeshProUGUI tmp;



    
    void Start()
    {
        count = 0;
        tmp= GetComponent<TextMeshProUGUI>();
    }

    public void chCount(int x)
    {
        count+= x;
        tmp.text = count.ToString();
    }
}
