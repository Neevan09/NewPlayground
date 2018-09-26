using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;
    public float smoothFactor;
    void Start ()
    {
        cameraOffset = transform.position - playerTransform.position;
	}	
	void Update ()
    {
        Vector3 newPos = playerTransform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
	}
}
