using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateProbeModel : MonoBehaviour
{
    public GameObject linearModel;
    private ProbeModelSwitch1 pms;

    // Start is called before the first frame update
    void Start()
    {
        pms = linearModel.transform.parent.GetComponent<ProbeModelSwitch1>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (linearModel.activeInHierarchy)
            {
                pms.setCurve();
            }
            else
            {
                pms.setLinear();
            }
        }
    }
}
