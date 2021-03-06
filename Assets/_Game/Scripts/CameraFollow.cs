using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followLocation;
    public Vector3 offset;
    public float smoothTime = 0.5f;

    Vector3 velocity;
    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, followLocation.position + offset, ref velocity, smoothTime / Vector3.Distance(transform.position, followLocation.position + offset));
    }
}
