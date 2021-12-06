using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DepthControl : MonoBehaviour
{

    public Camera cam; //you are setting up a function that changes the camera depth (clipping planes?) get the onclick from mrtk button
    //public Text depthLabel;
    private float minDepth = .23f;
    private float maxDepth = .37f;
    //private string depthUnitText = "mm";

    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*
    // Update is called once per frame
    void Update()
    {
        var depthChange = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        var changeVal = (float)(depthChange.y);

        var afterChange = depthFilter.transform.localScale[2] - changeVal / scaleSpeed;

        //depthLabel.text = calculateDepth().ToString("0.##") + depthUnitText;
        if (changeVal != 0.0 && afterChange >= 0 && afterChange <= 2)
        {
            depthFilter.transform.localScale -= new Vector3(0, 0, changeVal / scaleSpeed);

        }
    }
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
