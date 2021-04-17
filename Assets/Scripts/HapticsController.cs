using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HapticsController : MonoBehaviour
{
    public float amp;
    public float freq;
    public string whichHand;

    public void resetHaptics()
    {
        if (whichHand == "right")
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
        }
        if (whichHand == "left")
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.LTouch);
        }

    }
    public void setHaptics()
    {
        if (whichHand == "right")
        {
            OVRInput.SetControllerVibration(freq, amp, OVRInput.Controller.RTouch);
        }
        if (whichHand == "left")
        {
            OVRInput.SetControllerVibration(freq, amp, OVRInput.Controller.LTouch);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision: " + collision.gameObject.name);
        if (collision.gameObject.name == "Body" || collision.gameObject.name == "HuMan")
        {
            setHaptics();
            Debug.Log("Setting Haptics");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Body")
        {
            resetHaptics();
            Debug.Log("Resetting Haptics");
        }
    }
}