using Ink.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class dialok : MonoBehaviour
{
    public TextMeshProUGUI tmpname;
    public TextMeshProUGUI tmp;
    public Story story;
    public TextAsset textAs;
    public GameObject prefabknopki;
    public GameObject panelnayapanell;
    private List<TextMeshProUGUI> listoftmp;
    public dialog logg;
    private dataCentr dC;
    public List<Choice> currentchoices;
    public Image img;
    public List<Sprite> imgs;
    public List<chardata> chrdt;
    [SerializeField] private Dictionary<string,int> naim=new Dictionary<string, int>();
    [SerializeField] private List<Sprite> imgess;
    [SerializeField] private List<Dictionary<string, Sprite>> list;

    private void Awake()
    { 
        story = new Story(textAs.text);
        naim.Add("Bulba", 0);
        naim.Add("gg", 1);
    }
    private void Start()
    {
        logg.enabled = true;
    }
    public void ContinueStory(bool cc= false)
    {
        if (story.canContinue)
        {
            ShowDialok();
            ShowButton();
            logg.enabled = false;
            return;
        }
        else if (!cc)
        {
            QuitDialok();
        }
    }

    private void QuitDialok()
    {
        logg.enabled = true;
        enabled = false;
        dC = FindObjectOfType<dataCentr>();
        Destroy(dC.detectNPC);
        img.sprite = imgess[0];
    }

    private void ShowButton()
    {
        Debug.Log(" -baton..");
        currentchoices = story.currentChoices;
        if(currentchoices.Count <= 0 ) {
            return;
        }
        for (int i = 0; i < currentchoices.Count; i++)
        {
            GameObject button = Instantiate(prefabknopki);
            button.transform.SetParent(panelnayapanell.transform);
            button.GetComponent<buttonEkshan>().indecksfotalnyii=i;
            listoftmp = panelnayapanell.GetComponentsInChildren<TextMeshProUGUI>().ToList();
            listoftmp[i].text = currentchoices[i].text;
        }
        //for (int i = 0; i < listoftmp.Count; i++)
        //{

        //}
    }

    private void ShowDialok()
    {
        tmp.text = story.Continue();
        tmpname.text = story.variablesState["charname"].ToString();
        NameImag(story.variablesState["charname"].ToString(), naim[story.variablesState["charname"].ToString()]);
    }

    private void NameImag(string charnam, int danuint)
    {
        int oint = (int)story.variablesState["emotion"];
       // img.sprite = naim[charnam];
        img.sprite = chrdt[danuint].sprut[oint];
    /*    if (story.variablesState["charname"].ToString() == "Nyaaaaa")
        {
            Debug.Log("ouuuu");
            img.sprite = imgess[1];
        }
        else if (story.variablesState["charname"].ToString() == "nya")
        {
            img.sprite = imgess[0];
        } */
    } 

    public void BatonEkshn(int induk)
    {
        story.ChooseChoiceIndex(induk);
        panelnayapanell.transform.Cast<Transform>().ToList().ForEach(child=>Destroy(child.gameObject));   
        ContinueStory(true);
        logg.enabled = false;
        enabled = true;
    }

}
[Serializable]
public class chardata
{
    public string namechar;
    public List<Sprite> sprut;
}
