using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelMode : MonoBehaviour
{
    bool travelModeActive;
    public RawImage minimap;
    public GameObject patientX;
    public GameObject patientY;
    public GameObject user;

    // Start is called before the first frame update
    void Start()
    {
        travelModeActive = true;
        minimap.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstick))
        {
            if (travelModeActive)
            {
                travelModeActive = false;
                minimap.gameObject.SetActive(false);
            }

            else
            {
                travelModeActive = true;
                minimap.gameObject.SetActive(true);
            }
        }

        if (OVRInput.GetUp(OVRInput.RawButton.X))
        {
            //user.transform.position = patientX.transform.position + Vector3.left + Vector3.up;
            Vector3 userPos = user.transform.position;
            user.transform.position = new Vector3(0, 0, 0);
            user.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
            Vector3 newPos = new Vector3(patientX.transform.position.x - 2, userPos.y, patientX.transform.position.z - 0.5f);
            user.transform.position = newPos;
            //user.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }

        if (OVRInput.GetUp(OVRInput.RawButton.Y))
        {
            //user.transform.position = patientY.transform.position + Vector3.left + Vector3.up;
            Vector3 userPos = user.transform.position;
            user.transform.position = new Vector3(0, 0, 0);
            user.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
            Vector3 newPos = new Vector3(patientY.transform.position.x - 2, userPos.y, patientY.transform.position.z - 0.5f);
            user.transform.position = newPos;
            //user.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }
    }
}
