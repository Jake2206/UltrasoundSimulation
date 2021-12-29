using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClippingPlaneControl : MonoBehaviour
{
    public float farOffset = 0.005f;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        //camera = GameObject.Find("UltraSonicProbe").GetComponent<Camera>();
        camera.nearClipPlane = 0.30f;
        camera.farClipPlane = camera.nearClipPlane + farOffset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
