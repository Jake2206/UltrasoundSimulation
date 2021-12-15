﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;

public class GainUpdate : MonoBehaviour
{
    public GameObject sliderParent;
    private PinchSlider sliderScript;
    private GainControl dc;
    private float cur_pos;

    // Start is called before the first frame update
    void Start()
    {
        sliderScript = sliderParent.GetComponent<PinchSlider>();
        cur_pos = sliderScript.SliderValue;
        dc = sliderParent.GetComponent<GainControl>();
    }

    private void Update()
    {
        if (sliderScript.SliderValue != cur_pos)
        {
            sendUpdate(sliderScript.SliderValue);
            cur_pos = sliderScript.SliderValue;
        }
    }

    public void sendUpdate(float sliderValue)
    {
        //Debug.Log(sliderValue.ToString());
        dc.updateDepth(sliderValue - cur_pos);
        cur_pos = sliderScript.SliderValue;
    }
}
