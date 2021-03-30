using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeModelSwitch : MonoBehaviour
{

    public GameObject linearModel;
    public GameObject curveModel;
    public GameObject linearFilter;
    public GameObject curveFilter;

    // Start is called before the first frame update
    void Start()
    {
        linearModel.SetActive(false);
        curveModel.SetActive(true);
        linearFilter.SetActive(false);
        curveFilter.SetActive(true);
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
                linearFilter.SetActive(false);
                curveFilter.SetActive(true);
            }
            else
            {
                linearModel.SetActive(true);
                curveModel.SetActive(false);
                linearFilter.SetActive(true);
                curveFilter.SetActive(false);
            }
        }
    }
}
