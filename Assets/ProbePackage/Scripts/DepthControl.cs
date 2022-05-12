using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DepthControl : MonoBehaviour
{

    public Camera r_cam; //this is the camera on the RH probe
    public RawImage curveImage;
    public RawImage linearImage;
    private float minDepth = 0.5f;
    private float maxDepth = 1.0f;
    public TMP_Text curveDepthLabel;
    public TMP_Text linearDepthLabel;
    private float scale = 0.5f;

    /// <summary>
    /// Update the depth of the uvRect on the rawImage being projected onto the probe screen.
    /// Make sure it is within the max and min bounds of depth.
    /// </summary>
    public void updateDepth(float change)
    {
        scale -= change; //Mathf.Round((scale-change) * 10) *.1f;
        float newDepth = Mathf.Lerp(minDepth, maxDepth, scale);
        float curveCentis = Mathf.Round(Mathf.Lerp(4f, 15f, scale) * 100.0f) * 0.01f;
        float linearCentis = Mathf.Round(Mathf.Lerp(2f, 6f, scale) * 100.0f) * 0.01f;
        curveDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", curveCentis/2, curveCentis);
        linearDepthLabel.text = string.Format("-\n\n-\n\n-\n\n-\n\n-{0}\n\n-\n\n-\n\n-\n\n-{1} cm", linearCentis/2, linearCentis);
        curveImage.uvRect = new Rect(curveImage.uvRect.x, curveImage.uvRect.y, curveImage.uvRect.height, newDepth);
        linearImage.uvRect = new Rect(linearImage.uvRect.x, linearImage.uvRect.y, linearImage.uvRect.height, newDepth);
    }
}
