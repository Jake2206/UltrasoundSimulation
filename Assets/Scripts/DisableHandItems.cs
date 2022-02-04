using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableHandItems : MonoBehaviour
{
    public GameObject screen;
    public GameObject transducerL;
    public GameObject syringeL;
    public GameObject transducerR;
    public GameObject syringeR;
    private bool leftActive = false;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collision: " + other.gameObject.name);
        if (other.gameObject.tag == "screen")
        {
            if (transducerR.activeInHierarchy)
            {
                transducerR.SetActive(false);
                syringeL.SetActive(false);
                leftActive = false;
            }
            else
            {
                transducerL.SetActive(false);
                syringeR.SetActive(false);
                leftActive = true;

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Collision: " + other.gameObject.name);
        if (other.gameObject.tag == "screen")
        {
            if (leftActive)
            {
                transducerL.SetActive(true);
                syringeR.SetActive(true);
            }
            else
            {
                syringeL.SetActive(true);
                transducerR.SetActive(true);
            }
        }
    }
}
