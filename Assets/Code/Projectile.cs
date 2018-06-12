using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public Vector3 ExplosionPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        if (collision.gameObject.tag == "Damage")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(500, transform.position + ExplosionPos, 20);
            Destroy(gameObject);
        }
    }
}
