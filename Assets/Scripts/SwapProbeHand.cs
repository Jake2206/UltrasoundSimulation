using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapProbeHand : MonoBehaviour
{
    public GameObject l_probe;
    public GameObject l_syringe;
    public GameObject r_probe;
    public GameObject r_syringe;
    public RenderTexture rt;
    private bool touchingUI;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            if (!touchingUI)
            {
                switch_hands();
            }
        }
    }

    void switch_hands()
    {
        if (r_probe.activeInHierarchy)
        {
            r_probe.SetActive(false);
            r_syringe.SetActive(true);
            l_probe.SetActive(true);
            l_syringe.SetActive(false);
        }
        else
        {
            r_probe.SetActive(true);
            r_syringe.SetActive(false);
            l_probe.SetActive(false);
            l_syringe.SetActive(true);
        }
        rt.Release();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collision: " + other.gameObject.name);
        if (other.gameObject.tag == "screen")
        {
            touchingUI = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Collision: " + other.gameObject.name);
        if (other.gameObject.tag == "screen")
        {
            touchingUI = false;
        }
    }
}
