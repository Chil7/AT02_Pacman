using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inky : Ghost
{
    [SerializeField] private Vector3 offset;
    public NavMeshAgent inkyAgent;
    protected override void Awake()
    {
        base.Awake();
        DefaultState = new GhostState_Flank(this, offset);
        inkyAgent = GetComponent<NavMeshAgent>();
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    private void OnDrawGizmos()
    {
        if (Target != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(Target.transform.position + offset, 0.25f);
        }
    }
}
