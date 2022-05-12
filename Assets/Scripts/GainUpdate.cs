using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;

public class GainUpdate : MonoBehaviour
{
    public GameObject sliderParent;
    private PinchSlider sliderScript;
    private GainControl gc;
    private float cur_pos;

    // Start is called before the first frame update
    void Start()
    {
        sliderScript = sliderParent.GetComponent<PinchSlider>();
        cur_pos = sliderScript.SliderValue;
        gc = sliderParent.GetComponent<GainControl>();
    }

    private void Update()
    {
        if (sliderScript.SliderValue != cur_pos)
        {
            sendUpdate(sliderScript.SliderValue);
            cur_pos = sliderScript.SliderValue;
        }
    }

    /// <summary>
    /// Send slider value to gain control script to update the probe image gain.
    /// </summary>
    /// <param name="sliderValue"></param>
    public void sendUpdate(float sliderValue)
    {
        gc.updateGain(sliderValue - cur_pos);
    }
}
