using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overlapKill : MonoBehaviour {

    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "arch")
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "arch")
        {
            Destroy(gameObject);
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "arch")
        {
            Destroy(gameObject);
        }
    }
}
