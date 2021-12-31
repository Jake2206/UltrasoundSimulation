using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DepthControl : MonoBehaviour
{

    public Camera cam; //this is the camera on the probe
    //public Text depthLabel;
    private float orthoMinDepth = .025f;
    private float orthoMaxDepth = .035f;

    //private string depthUnitText = "mm";

    // Start is called before the first frame update
    void Start()
    {
    }

    /// <summary>
    /// Update the depth of the clipping plane on the probe camera.
    /// Make sure it is within the max and min bounds of depth.
    /// </summary>
    public void updateDepth(float change)
    {
        change *= .1f;
        if (change > 0)
        {
            if ((cam.orthographicSize + change) <= orthoMaxDepth)
            {
                cam.orthographicSize += change;
            }
            else
            {
                cam.orthographicSize = orthoMaxDepth;
            }
        }
        else
        {
            if (cam.orthographicSize + change > orthoMinDepth)
            {
                cam.orthographicSize += change;
            }
            else
            {
                cam.orthographicSize = orthoMinDepth;
            }
        }
        return;
    }
}
