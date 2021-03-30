using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClippingPlaneControl : MonoBehaviour
{

    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        //camera = GameObject.Find("UltraSonicProbe").GetComponent<Camera>();
        camera.nearClipPlane = 0.30f;
        camera.farClipPlane = 0.301f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
