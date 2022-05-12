using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateProbeModel : MonoBehaviour
{
    public GameObject linearModel;
    private ProbeModelSwitch1 pms;
    public RenderTexture rt;

    // Start is called before the first frame update
    void Start()
    {
        pms = linearModel.transform.parent.GetComponent<ProbeModelSwitch1>();
    }

    public void switchModel()
    {
        if (linearModel.activeInHierarchy)
        {
            pms.setCurve();
        }
        else
        {
            pms.setLinear();
        }
        rt.Release();
    }
}
