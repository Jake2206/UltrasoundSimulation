using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DepthControl : MonoBehaviour
{

    public Camera r_cam; //this is the camera on the RH probe
    public Camera l_cam; //this is the camera on the LH probe
    public RawImage curveImage;
    public RawImage linearImage;
    private float minDepth = 0.5f;
    private float maxDepth = 1.0f;
    public TMP_Text curveDepthLabel;
    public TMP_Text linearDepthLabel;
    private float scale = 0.5f;

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
        scale = ((curveImage.uvRect.height + change) - minDepth) / (maxDepth - minDepth);
        float curveCentis = Mathf.Round(Mathf.Lerp(4f, 15f, scale) * 100.0f) * 0.01f;
        float linearCentis = Mathf.Round(Mathf.Lerp(2f, 6f, scale) * 100.0f) * 0.01f;
        //Debug.Log(change);
        //Debug.Log(curveImage.uvRect);
        if (change > 0)
        {
            if ((curveImage.uvRect.height + change) <= maxDepth)
            {
                curveDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", curveCentis/2, curveCentis);
                linearDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", linearCentis / 2, linearCentis);
                curveImage.uvRect = new Rect(curveImage.uvRect.x, curveImage.uvRect.y, curveImage.uvRect.height+change, curveImage.uvRect.width+change);
                linearImage.uvRect = new Rect(linearImage.uvRect.x, linearImage.uvRect.y, linearImage.uvRect.height, linearImage.uvRect.width + change);
            }
            else
            {
                curveDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", curveCentis / 2, curveCentis);
                linearDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", linearCentis / 2, linearCentis);
                curveImage.uvRect = new Rect(curveImage.uvRect.x, curveImage.uvRect.y, maxDepth, maxDepth);
                linearImage.uvRect = new Rect(linearImage.uvRect.x, linearImage.uvRect.y, maxDepth, maxDepth);
            }
        }
        else
        {
            if (curveImage.uvRect.height + change > minDepth)
            {
                curveDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", curveCentis / 2, curveCentis);
                linearDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", linearCentis / 2, linearCentis);
                curveImage.uvRect = new Rect(curveImage.uvRect.x, curveImage.uvRect.y, curveImage.uvRect.height + change, curveImage.uvRect.width + change);
                linearImage.uvRect = new Rect(linearImage.uvRect.x, linearImage.uvRect.y, linearImage.uvRect.height, linearImage.uvRect.width + change);
            }
            else
            {
                curveDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", curveCentis / 2, curveCentis);
                linearDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", linearCentis / 2, linearCentis);
                curveImage.uvRect = new Rect(curveImage.uvRect.x, curveImage.uvRect.y, minDepth, minDepth);
                linearImage.uvRect = new Rect(linearImage.uvRect.x, linearImage.uvRect.y, minDepth, minDepth);
            }
        }
        return;
    }
}
