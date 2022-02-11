using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarnBodyCol : MonoBehaviour
{
    public Text warning;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collide");
        //Debug.Log("Collision: " + collision.gameObject.name);
        if (collision.gameObject.tag == "body")
        {
            Debug.Log("Body");
            warning.enabled = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        //Debug.Log("Collision: " + collision.gameObject.name);
        if (collision.gameObject.tag == "body")
        {
            warning.enabled = false;
        }
    }


}
