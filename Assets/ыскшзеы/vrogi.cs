using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class vrogi : smenaNaZavode
{
    private GameObject natural;
    private Vector3 ve3;
    public float speed;
    [HideInInspector] public NavMeshAgent agent;
    public klochokgryadki kg;
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        speed=agent.speed;
        kg = FindAnyObjectByType<klochokgryadki>();
        states(new movevrog(this));
    }

    void Update()
    {
        
    }
}
