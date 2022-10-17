using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTracker : MonoBehaviour
{
    [Tooltip("The target to be tracked. ")]
    [SerializeField] private Transform target;
    [Tooltip("The offset position form the target")]
    [SerializeField] private Vector3 positionOffset;

    void LateUpdate()
    {
        //camera tracks the target every end of the frame
        transform.position = target.position + positionOffset;
    }
}
