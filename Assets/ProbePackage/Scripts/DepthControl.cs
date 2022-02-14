using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DepthControl : MonoBehaviour
{

    public Camera r_cam; //this is the camera on the RH probe
    public Camera l_cam; //this is the camera on the LH probe
    public RawImage curveImage;
    public RawImage linearImage;
    private float minDepth = 0.5f;
    private float maxDepth = 1.0f;
    //public Text depthLabel;
    //private float orthoMinDepth = .025f;
    //private float orthoMaxDepth = .035f;

    //private string depthUnitText = "mm";

    // Start is called before the first frame update
    void Start()
    {
    }

    /// <summary>
    /// Update the depth of the uvRect on the rawImage being projected onto the probe screen.
    /// Make sure it is within the max and min bounds of depth.
    /// </summary>
    public void updateDepth(float change)
    {
        change = change/2;
        Debug.Log(change);
        //Debug.Log(curveImage.uvRect);
        if (change > 0)
        {
            if ((curveImage.uvRect.height + change) <= maxDepth) //orthoMaxDepth)
            {
                curveImage.uvRect = new Rect(curveImage.uvRect.x, curveImage.uvRect.y, curveImage.uvRect.height+change, curveImage.uvRect.width+change);
                //curveImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, curveImage.rectTransform.sizeDelta.y);
                //l_cam.orthographicSize += change;
                //r_cam.orthographicSize += change;
            }
            else
            {
                curveImage.uvRect = new Rect(curveImage.uvRect.x, curveImage.uvRect.y, maxDepth, maxDepth);
                //curveImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, curveImage.rectTransform.sizeDelta.y);
                //l_cam.orthographicSize = orthoMaxDepth;
                //r_cam.orthographicSize = orthoMaxDepth;
            }
        }
        else
        {
            if (curveImage.uvRect.height + change > minDepth)//orthoMinDepth)
            {
                curveImage.uvRect = new Rect(curveImage.uvRect.x, curveImage.uvRect.y, curveImage.uvRect.height + change, curveImage.uvRect.width + change);
                //curveImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, curveImage.rectTransform.sizeDelta.y);
                //l_cam.orthographicSize += change;
                //r_cam.orthographicSize += change;
            }
            else
            {
                curveImage.uvRect = new Rect(curveImage.uvRect.x, curveImage.uvRect.y, minDepth, minDepth);
                //curveImage.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, curveImage.rectTransform.sizeDelta.y);
                //l_cam.orthographicSize = orthoMinDepth;
                //r_cam.orthographicSize = orthoMinDepth;
            }
        }
        return;
    }
}
