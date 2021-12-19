using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DepthControl : MonoBehaviour
{

    public Camera orthoCam; //this is the camera on the probe
    //public Camera curveCam; //this is the camera on the probe
    //public Text depthLabel;
    private float orthoMinDepth = .025f;
    private float orthoMaxDepth = .035f;
    //private float curveMinDepth = .05f;
    //private float curveMaxDepth = .15f;
    //private float orig_ortho_ypos;

    //private string depthUnitText = "mm";

    // Start is called before the first frame update
    void Start()
    {
        //orig_ortho_ypos = orthoCam.gameObject.transform.position.y;
        //cam = GameObject.Find("UltraSonicProbe").GetComponent<Camera>();
    }
    /*
    Update the depth of the clipping plane on the probe camera.
    Make sure it is within the max and min bounds of depth.
    */
    public void updateDepth(float change)
    {
        change *= .1f;
        //float changeCurve = change * 0.1f;
        //Vector3 pos = orthoCam.gameObject.transform.localPosition;
        //Rect rec = orthoCam.rect;
        Debug.Log(orthoCam.orthographicSize);
        Debug.Log(change);
        if (change > 0)
        {
            if ((orthoCam.orthographicSize + change) <= orthoMaxDepth)
            {
                //orthoCam.rect = new Rect(rec.x, rec.y, rec.width + changeOrtho, rec.height);
                // orthoCam.gameObject.transform.localPosition = new Vector3(pos.x, pos.y, pos.z + changeOrtho);
                orthoCam.orthographicSize += change;
            }
            else
            {
                //orthoCam.rect = new Rect(rec.x, rec.y, .85f, rec.height);
                //orthoCam.gameObject.transform.localPosition = new Vector3(pos.x, pos.y, orig_ortho_ypos + 1.5f);
                orthoCam.orthographicSize = orthoMaxDepth;
            }
            /*if ((curveCam.farClipPlane + changeCurve) < curveMaxDepth)
            {
                curveCam.farClipPlane += changeCurve;
            }
            else
            {
                curveCam.farClipPlane = curveMaxDepth;
            }*/
        }
        else
        {
            if (orthoCam.orthographicSize + change > orthoMinDepth)
            {
                //orthoCam.rect = new Rect(rec.x, rec.y, rec.width + changeOrtho, rec.height);
                //orthoCam.gameObject.transform.localPosition = new Vector3(pos.x, pos.y, pos.z + changeOrtho);
                orthoCam.orthographicSize += change;
            }
            else
            {
                //orthoCam.rect = new Rect(rec.x, rec.y, .55f, rec.height);
                //orthoCam.gameObject.transform.localPosition = new Vector3(pos.x, pos.y, orig_ortho_ypos - 1.5f);
                orthoCam.orthographicSize = orthoMinDepth;
            }
            /*if ((curveCam.farClipPlane + changeCurve) > curveMinDepth)
            {
                curveCam.farClipPlane += changeCurve;
            }
            else
            {
                curveCam.farClipPlane = curveMinDepth;
            }*/
        }
        return;
    }
}
