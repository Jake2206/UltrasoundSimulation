using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    private Vector3 start_pos;

    // Start is called before the first frame update
    void Start()
    {
        start_pos = player.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision: " + collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            player.transform.position = start_pos;
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
