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
    private Vector3 left_syringe_pos;
    private Vector3 right_syringe_pos;
    private Vector3 left_transducer_pos;
    private Vector3 right_transducer_pos;

    private void Start()
    {
        left_syringe_pos = syringeL.transform.localPosition;
        right_syringe_pos = syringeR.transform.localPosition;
        left_transducer_pos = transducerL.transform.localPosition;
        right_transducer_pos = transducerR.transform.localPosition;
}
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
                transducerL.transform.localPosition = left_transducer_pos;
                syringeR.transform.localPosition = right_syringe_pos;
            }
            else
            {
                syringeL.SetActive(true);
                transducerR.SetActive(true);
                transducerR.transform.localPosition = right_transducer_pos;
                syringeL.transform.localPosition = left_syringe_pos;
            }
        }
    }
}
