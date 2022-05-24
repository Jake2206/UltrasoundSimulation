using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GainControl : MonoBehaviour
{
    public GameObject grayscaleHolder;
    private PostProcessVolume vol; //this is the postprocessing volume on the grayscale holder
    private ColorGrading colorGradingLayer;
    private float minGain = -1.25f;
    private float maxGain = 15f;
    private float scale = 0.5f;

    void Start()
    {
        vol = grayscaleHolder.GetComponent<PostProcessVolume>();
        vol.sharedProfile.TryGetSettings(out colorGradingLayer);
    }

    /// <summary>
    /// Update the color grading layer gain on the post processing layer.
    /// Makes sure it is within the max and min bounds of depth with a lerp.
    /// </summary>
    public void updateGain(float change)
    {
        scale += change;
        float newGain = Mathf.Lerp(minGain, maxGain, scale);
        Debug.Log(colorGradingLayer.gain.value);
        colorGradingLayer.gain.value = new Vector4(newGain, newGain, newGain, newGain);
    }
}
