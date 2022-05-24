using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject probe;
    private Vector3 probeLoc;
    private Quaternion probeRot;
    public GameObject syringe;
    private Vector3 syringeLoc;
    private Quaternion syringeRot;
    public GameObject screen;
    private Vector3 screenLoc;
    private Quaternion screenRot;
    public GameObject patient;
    private Vector3 patientLoc;

    // Start is called before the first frame update
    void Start()
    {
        probeLoc = probe.transform.position;
        probeRot = probe.transform.rotation;
        syringeLoc = syringe.transform.position;
        syringeRot = syringe.transform.rotation;
        screenLoc = screen.transform.position;
        screenRot = screen.transform.rotation;
        patientLoc = patient.transform.position;
    }

    public void ResetItems()
    {
        probe.transform.position = probeLoc;
        probe.transform.rotation = probeRot;
        syringe.transform.position = syringeLoc;
        syringe.transform.rotation = syringeRot;
        screen.transform.position = screenLoc;
        screen.transform.rotation = screenRot;
        patient.transform.position = patientLoc;
    }
}
