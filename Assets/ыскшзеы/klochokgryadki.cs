using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class klochokgryadki : MonoBehaviour
{
    
    private ffff ff;
    public Texture re;



    public List<Texture> te = new List<Texture>();
    
    
    
    void Start()
    {
        ff= FindObjectOfType<ffff>();
    }
    void Update()
    {
        if (gameObject.GetComponent<Renderer>().material.mainTexture == ff.ty)
        {
            StartCoroutine(corica());
        }
    }
    IEnumerator corica()
    {
        for (int i = 0; i < te.Count; i++)
        {
            gameObject.GetComponent<Renderer>().material.mainTexture = te[i];
            yield return new WaitForSeconds(5);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<vrogi>(out vrogi vro))
        {
            collision.gameObject.GetComponent<Renderer>().material.mainTexture = re;
        }
    }
}
