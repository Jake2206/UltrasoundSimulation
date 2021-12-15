using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DepthControl : MonoBehaviour
{

    public Camera cam; //this is the camera on the probe
    //public Text depthLabel;
    private float minDepth = .23f;
    private float maxDepth = .37f;
    //private string depthUnitText = "mm";

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("UltraSonicProbe").GetComponent<Camera>();
    }
    /*
    Update the depth of the clipping plane on the probe camera.
    Make sure it is within the max and min bounds of depth.
    */
    public void updateDepth(float change)
    {
        if (change > 0)
        {
            if ((cam.farClipPlane + change) < maxDepth)
            {
                cam.farClipPlane += change;
                cam.nearClipPlane += change;
            }
            else
            {
                cam.farClipPlane = maxDepth;
                cam.nearClipPlane = maxDepth - 1;
            }
        }
        else
        {
            if (cam.nearClipPlane > minDepth)
            {
                cam.nearClipPlane += change;
                cam.farClipPlane += change;
            }
            else
            {
                cam.nearClipPlane = minDepth;
                cam.farClipPlane = minDepth + 1;
            }
        }
        return;
    }
}
