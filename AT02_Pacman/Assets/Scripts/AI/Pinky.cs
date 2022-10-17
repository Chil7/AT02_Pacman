using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pinky : Ghost
{
    [SerializeField] private Vector3 offset;
    public NavMeshAgent pinkyAgent;
    protected override void Awake()
    {
        base.Awake();
        DefaultState = new GhostState_Flank(this, offset);
        pinkyAgent = GetComponent<NavMeshAgent>();
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
            Gizmos.color = Color.magenta;
            Gizmos.DrawSphere(Target.transform.position + offset, 0.25f);
        }
    }
}
