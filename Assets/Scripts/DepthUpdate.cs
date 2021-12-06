using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;

public class DepthUpdate : MonoBehaviour
{
    public GameObject sliderParent;
    private PinchSlider sliderScript;
    private DepthControl dc;
    private float cur_pos;

    // Start is called before the first frame update
    void Start()
    {
        sliderScript = sliderParent.GetComponent<PinchSlider>();
        cur_pos = sliderScript.SliderValue;
    }

    void OnSliderUpdated(SliderEventData eventData)
    {
        dc.updateDepth(sliderScript.SliderValue - cur_pos);
        cur_pos = sliderScript.SliderValue;
    }
}
