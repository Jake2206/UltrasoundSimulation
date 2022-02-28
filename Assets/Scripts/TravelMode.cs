using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelMode : MonoBehaviour
{
    public GameObject patientX;
    public GameObject user;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //move to the patient
        if (OVRInput.GetUp(OVRInput.RawButton.Y))
        {
            user.gameObject.SetActive(false);
            Vector3 userPos = user.transform.position;
            Vector3 newPos = new Vector3(patientX.transform.position.x - 2, userPos.y, patientX.transform.position.z - 0.5f);
            user.transform.position = newPos;
            user.gameObject.SetActive(true);
        }
    }
}
