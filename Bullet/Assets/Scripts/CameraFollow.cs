using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 Offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    private Vector3 currentVelocity = Vector3.zero;

    private void Awake()
    {
        Offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        Vector3 targetPotioin = target.position + Offset;
        transform.position = Vector3.SmoothDamp(current: transform.position, targetPotioin, ref currentVelocity, smoothTime);
    }
}
