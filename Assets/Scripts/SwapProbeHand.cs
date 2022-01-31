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
    //private Vector3 r_pos;
    //private Vector3 l_pos;
    //private Quaternion r_rot_probe;
    //private Quaternion l_rot_syringe;
    //private Quaternion l_rot_probe;
    //private Quaternion r_rot_syringe;
    //private Transform right_hand;
    //private Transform left_hand;

    // Start is called before the first frame update
    void Start()
    {
        //right_hand = probe.transform.parent;
        //left_hand = syringe.transform.parent;
  
        //l_pos = syringe.transform.position;
        //r_pos = probe.transform.position;

        //r_rot_syringe = syringe.transform.localRotation;
        //l_rot_probe = probe.transform.localRotation;

        //l_rot_syringe = new Quaternion(-21.693f, 174.547f, 8.278f, 0);
        //r_rot_probe = new Quaternion(73.775f, -102.465f, -95.91701f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            switch_hands();
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
            //probe.transform.parent = left_hand;
            //syringe.transform.parent = right_hand;
            //probe.transform.position = l_pos;
            //syringe.transform.position = r_pos;
            //probe.transform.localRotation = l_rot_probe;
            //syringe.transform.localRotation = r_rot_syringe;
        }
        else
        {
            r_probe.SetActive(true);
            r_syringe.SetActive(false);
            l_probe.SetActive(false);
            l_syringe.SetActive(true);
            //probe.transform.parent = right_hand;
            //syringe.transform.parent = left_hand;
            //probe.transform.position = r_pos;
            //syringe.transform.position = l_pos;
            //probe.transform.localRotation = r_rot_probe;
            //syringe.transform.localRotation = l_rot_syringe;
        }
        rt.Release();
        
    }
}
