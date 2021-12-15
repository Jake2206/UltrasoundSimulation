using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeModelSwitch : MonoBehaviour
{

    public GameObject linearModel;
    public GameObject curveModel;

    // Start is called before the first frame update
    void Start()
    {
        linearModel.SetActive(false);
        curveModel.SetActive(true);
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
            }
            else
            {
                linearModel.SetActive(true);
                curveModel.SetActive(false);
            }
        }
    }
}
