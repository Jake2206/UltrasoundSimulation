using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GainControl : MonoBehaviour
{
    public GameObject grayscaleHolder;
    private PostProcessVolume vol; //this is the postprocessing volume on the grayscale holder
    private ColorGrading colorGradingLayer;
    private float ev;
    //public Text gainLabel;
    private float minGain = -2.5f;
    private float maxGain = 5.5f;
    private float scale = 0.5f;
    //private string gainUnitText = "mm";

    // Start is called before the first frame update
    void Start()
    {
        vol = grayscaleHolder.GetComponent<PostProcessVolume>();
        vol.sharedProfile.TryGetSettings(out colorGradingLayer);
        Debug.Log(colorGradingLayer.contrast.value);
        //cam = GameObject.Find("UltraSonicProbe").GetComponent<Camera>();
    }

    /// <summary>
    /// Update the depth of the clipping plane on the probe camera.
    /// Makes sure it is within the max and min bounds of depth.
    /// </summary>
    public void updateGain(float change)
    {
        scale += change;
        ev = colorGradingLayer.postExposure.value;
        float newGain = Mathf.Lerp(-2.5f, 5.5f, scale);
        Debug.Log(scale);
        Debug.Log(newGain);
        if (change > 0)
        {
            if (newGain < maxGain)
            {
                colorGradingLayer.postExposure.value = newGain;
            }
            else
            {
                colorGradingLayer.postExposure.value = maxGain;
            }
        }
        else
        {
            if (newGain > minGain)
            {
                colorGradingLayer.postExposure.value = newGain;
            }
            else
            {
                colorGradingLayer.postExposure.value = minGain;
            }
        }
        return;
    }
}
