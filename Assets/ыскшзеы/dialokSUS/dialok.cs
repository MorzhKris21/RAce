using Ink.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public List<chardata> chrdt;
    private Dictionary<string,int> naim=new Dictionary<string, int>();
    //[SerializeField] private List<Sprite> imgess;
    [SerializeField] private List<Dictionary<string, Sprite>> list;
    [SerializeField] private TextAsset KarfanTxt;

    private void Awake()
    {

        dC = FindObjectOfType<dataCentr>();
        naim.Add("Bulba", 0);
        naim.Add("gg", 1);
    }
    private void Start()
    {
        logg.enabled = true;
    }
    public void ContinueStory(bool cc= false)
    {
        Debug.Log(dC.detectNPC.name);
        if (!dC.detectNPC.IsUnityNull()) 
        {
            
            story = new Story(dC.detectNPC.GetComponent<npc>().Type == npcType.simplenpc ? textAs.text : KarfanTxt.text);

        }
        if (story.canContinue)
        {
            ShowDialok();
            ShowButton();
            logg.enabled = false;
        }
        else if (!cc)
        {
            QuitDialok();
        }
    }
    IEnumerator Animashka(int jj)
    {
        for(int x=0 ; x < 4; x++)
        {
            img.sprite = chrdt[jj].sprut[x];
            yield return new WaitForSeconds(0.1f);
        }
        
    }

    private void QuitDialok()
    {
        logg.enabled = true;
        enabled = false;
        Destroy(dC.detectNPC);
        //img.sprite = imgess[0];
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

    private async UniTaskVoid ShowDialok()
    {
        int ani = await (int)story.variablesState["anim"];
        string vscn =  story.variablesState["charname"].ToString();

        tmp.text = story.Continue();

        tmpname.text = vscn;
        if(ani == 1 )
        {
            StartCoroutine(Animashka(1));
            //return;
        }
        NameImag(naim[vscn]);
    }

    private void NameImag(int danuint)
    {
        int oint = (int)story.variablesState["emotion"];
        img.sprite = chrdt[danuint].sprut[oint];
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
