using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepthControl : MonoBehaviour
{

    public GameObject depthFilter;
    public Text depthLabel;
    private double maxDepth = 5.0;
    private int scaleSpeed = 200;
    private double depthScale = 1.0;
    private string depthUnitText = "mm";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var depthChange = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        var changeVal = (float)(depthChange.y);

        var afterChange = depthFilter.transform.localScale[2] - changeVal / scaleSpeed;

        depthLabel.text = calculateDepth().ToString("0.##") + depthUnitText;
        if (changeVal != 0.0 && afterChange >= 0 && afterChange <= 2)
        {
            depthFilter.transform.localScale -= new Vector3(0, 0, changeVal / scaleSpeed);

        }
    }

    double calculateDepth()
    {
        var localScaleY = depthFilter.transform.localScale[2];
        var depth = maxDepth - localScaleY / depthScale;
        return depth;
    }
}
