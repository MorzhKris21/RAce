using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;


public class klochokgryadki : MonoBehaviour
{
    
    private ffff ff;
    public Texture re;



    public List<Texture> te = new List<Texture>();

    public List<GameObject> ma = new List<GameObject>();


    void Start()
    {
        ff= FindObjectOfType<ffff>();
        /*for (int i = 0; i < 5; i++)
        {
            ma.Add();
            ma[i] = transform.GetChild(i).gameObject;
        }*/

        //ma = GetComponentsInChildren<GameObject>().ToList();
        Debug.Log(ma.Count);
    }
    void Update()
    {
        if (gameObject.GetComponent<Renderer>().material.mainTexture == ff.ty)
        {
            if(transform.GetChild(0).gameObject.activeInHierarchy)
                return;
            //transform.Cast<Transform>().ToList().ForEach(child=>);
            StartCoroutine(corica());
        }
    }
    IEnumerator corica()
    {
        for (int i = 0; i < ma.Count; i++)
        {
            if (i > 1)
            {
                ma[i - 1].SetActive(false);
            }
            ma[i].SetActive(true);
            //gameObject.GetComponent<Renderer>().material.mainTexture = te[i];
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
