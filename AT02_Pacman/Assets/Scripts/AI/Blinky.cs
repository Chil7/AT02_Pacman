using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Blinky : Ghost
{
    public NavMeshAgent blinkyAgent;
    protected override void Awake()
    {
        base.Awake();
        DefaultState = new GhostState_Chase(this);
        blinkyAgent = GetComponent<NavMeshAgent>();
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
}