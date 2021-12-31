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
    private float minGain = 0f;
    private float maxGain = 100f;
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
        //change = change * 100;
        ev = colorGradingLayer.postExposure.value;
        Debug.Log(ev);
        if (change > 0)
        {
            if ((ev + change) < maxGain)
            {
                colorGradingLayer.postExposure.value += change;
            }
            else
            {
                colorGradingLayer.postExposure.value = maxGain;
            }
        }
        else
        {
            if ((ev + change) > minGain)
            {
                colorGradingLayer.postExposure.value += change;
            }
            else
            {
                colorGradingLayer.postExposure.value = minGain;
            }
        }
        return;
    }
}
