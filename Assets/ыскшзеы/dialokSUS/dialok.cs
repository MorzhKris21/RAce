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
    private Dictionary<string, Sprite> naim=new Dictionary<string, Sprite>();
    [SerializeField] private List<Sprite> imgess;

    private void Awake()
    { 
        story = new Story(textAs.text);
        naim.Add("nya", imgess[0]);
        naim.Add("Nyaaaaa", imgess[1]);
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
        NameImag(story.variablesState["charname"].ToString());
    }

    private void NameImag(string charnam)
    {
        img.sprite = naim[charnam];
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
