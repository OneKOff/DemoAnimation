using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform followTarget;
    
    private void Update()
    {
        transform.position = followTarget.position;
    }
}
