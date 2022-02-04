using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DepthControl : MonoBehaviour
{

    public Camera r_cam; //this is the camera on the probe
    public Camera l_cam;
    public RawImage curveImage;
    public RawImage linearImage;
    private float minDepth;
    private float maxDepth;
    //public Text depthLabel;
    //private float orthoMinDepth = .025f;
    //private float orthoMaxDepth = .035f;

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
        //change *= .1f;
        Debug.Log(curveImage.rectTransform.sizeDelta);
        if (change > 0)
        {
            if ((l_cam.orthographicSize + change) <= maxDepth) //orthoMaxDepth)
            {
                curveImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, curveImage.rectTransform.sizeDelta.y);
                //l_cam.orthographicSize += change;
                //r_cam.orthographicSize += change;
            }
            else
            {
                curveImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, curveImage.rectTransform.sizeDelta.y);
                //l_cam.orthographicSize = orthoMaxDepth;
                //r_cam.orthographicSize = orthoMaxDepth;
            }
        }
        else
        {
            if (l_cam.orthographicSize + change > minDepth)//orthoMinDepth)
            {
                curveImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, curveImage.rectTransform.sizeDelta.y);
                //l_cam.orthographicSize += change;
                //r_cam.orthographicSize += change;
            }
            else
            {
                curveImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, curveImage.rectTransform.sizeDelta.y);
                //l_cam.orthographicSize = orthoMinDepth;
                //r_cam.orthographicSize = orthoMinDepth;
            }
        }
        return;
    }
}
