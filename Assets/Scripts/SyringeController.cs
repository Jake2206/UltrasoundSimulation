using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeController : MonoBehaviour
{
    public bool manipulationEnabled;
    // Vector3 insertionPoint = new Vector3(-2.701, 2.058, -0.116);
    // -25, 225, 0
    // 0.0008, 0.0008, 0.002
    // Vector3 injectDirection = new Vector3(0, 0, -1);
    public float injectRate = 0.00001f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!manipulationEnabled)
        {
            return;
        }
        Vector2 joystickValue = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
        Vector3 moveOffset = new Vector3(0, 0, -joystickValue.y);
        this.transform.position += Quaternion.Euler(-25, 225, 0) * moveOffset * injectRate;
        //this.transform.position += moveOffset * injectRate;
  }

    public void EnableManipulation()
    {
        manipulationEnabled = true;
    }

    public void DisableManipulation()
    {
        manipulationEnabled = false;
    }
}
