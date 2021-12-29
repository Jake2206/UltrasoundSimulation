using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelMode : MonoBehaviour
{
    bool travelModeActive;
    public GameObject patientX;
    public GameObject user;

    // Start is called before the first frame update
    void Start()
    {
        travelModeActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        //move to the patient
        if (OVRInput.GetUp(OVRInput.RawButton.Y))
        {
            //user.transform.position = patientX.transform.position + Vector3.left + Vector3.up;
            Vector3 userPos = user.transform.position;
            user.transform.position = new Vector3(0, 0, 0);
            user.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
            Vector3 newPos = new Vector3(patientX.transform.position.x - 2, userPos.y, patientX.transform.position.z - 0.5f);
            user.transform.position = newPos;
            //user.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }
    }
}
