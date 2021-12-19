using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProbeModelSwitch : MonoBehaviour
{

    public GameObject linearModel;
    public GameObject curveModel;
    public Camera orthoCam;
    //public Camera curveCam;
    public Image curveMask;
    public Image linearMask;

    // Start is called before the first frame update
    void Start()
    {
        linearModel.SetActive(false);
        curveModel.SetActive(true);
        linearMask.gameObject.SetActive(false);
        curveMask.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            if(linearModel.activeInHierarchy)
            {
                linearModel.SetActive(false);
                curveModel.SetActive(true);
                //orthoCam.enabled = false;
                //curveCam.enabled = true;
                linearMask.gameObject.SetActive(false);
                curveMask.gameObject.SetActive(true);
            }
            else
            {
                linearModel.SetActive(true);
                curveModel.SetActive(false);
                //curveCam.enabled = false;
                //orthoCam.enabled = true;
                linearMask.gameObject.SetActive(true);
                curveMask.gameObject.SetActive(false);
            }
        }
    }
}
