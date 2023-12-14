using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class dataCentr : smenaNaZavode
{
    public GameObject detectNPC;
    public CharacterController chara;
    public NovinochkaCC novinochkaCC;
    public Animator animator;
    public int sped;
    public Vector3 v3;
    public Transform trans;
    public int naspedah;
    public int sprig;
    public List <vrogi> vrogis;
    private ncoll nc;
    private countik cout;
    private ffff ffffff;

    public ncoll Nc => nc;
    public ffff Ff => ffffff;
    public countik cou => cout;


    public void uprig()
    {
        states(new vZaculise(this));

    }
    void OnEnable()
    {
        ffffff = GetComponent<ffff>();
        cout = FindObjectOfType<countik>();
        nc = GetComponent<ncoll>();
        sprig = 120;
        naspedah = 2;
        trans=Camera.main.transform;    
        v3 = Vector3.forward;
        sped = 24;
        novinochkaCC = GetComponent<NovinochkaCC>();
        animator = GetComponent<Animator>();
        chara= GetComponent<CharacterController>();
        states(new nedvigoetsya(this));

    }

}
