using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenEnabler : MonoBehaviour
{
    public RenderTexture renderTexture;
    public Camera probeCam;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision: " + collision.gameObject.name);
        if (collision.gameObject.tag == "body")
        {
            probeCam.enabled = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "body")
        {
            probeCam.enabled = false;
            renderTexture.Release();
        }
    }
}
