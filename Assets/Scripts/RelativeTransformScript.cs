using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativeTransformScript : MonoBehaviour
{

    public GameObject probe;
    private bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter (Collision collision)
    {
        isColliding = true;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    void OnCollisionStay (Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    void OnCollisionExit (Collision collision)
    {
        if (isColliding)
        {
            gameObject.transform.localPosition = Vector3.zero;
            gameObject.transform.localRotation = Quaternion.Euler(new Vector3(90, 0, 0));
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            isColliding = false;
        }        
    }
}
