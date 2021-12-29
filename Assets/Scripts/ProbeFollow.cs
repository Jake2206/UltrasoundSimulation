using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 1.0f;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(target.position, desiredPosition, smoothSpeed);
        transform.position = desiredPosition;
    }
}
