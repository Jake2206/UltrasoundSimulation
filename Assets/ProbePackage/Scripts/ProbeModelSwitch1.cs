using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProbeModelSwitch1 : MonoBehaviour
{
    public Camera cam;
    public GameObject linearModel;
    public GameObject curveModel;
    public Image curveMask;
    public Image linearMask;
    public TMP_Text curveDepthLabel;
    public TMP_Text linearDepthLabel;
    public RenderTexture rt;

    // Start is called before the first frame update
    void Start()
    {
        linearModel.SetActive(false);
        curveModel.SetActive(true);
        linearMask.gameObject.SetActive(false);
        curveMask.gameObject.SetActive(true);
        linearDepthLabel.enabled = false;

    }
    /// <summary>
    /// Activate linear transducer model and mask
    /// </summary>
    public void setLinear()
    {
        linearModel.SetActive(true);
        curveModel.SetActive(false);
        linearMask.gameObject.SetActive(true);
        curveMask.gameObject.SetActive(false);
        linearDepthLabel.enabled = true;
        curveDepthLabel.enabled = false;
        cam.transform.parent = linearModel.transform;
        rt.Release();
    }

    /// <summary>
    /// Activate curvilinear transducer model and mask
    /// </summary>
    public void setCurve()
    {
        linearModel.SetActive(false);
        curveModel.SetActive(true);
        linearMask.gameObject.SetActive(false);
        curveMask.gameObject.SetActive(true);
        linearDepthLabel.enabled = false;
        curveDepthLabel.enabled = true;
        cam.transform.parent = curveModel.transform;
        rt.Release();
    }
}
