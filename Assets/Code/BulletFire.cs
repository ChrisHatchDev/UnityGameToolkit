using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {

    public GameObject Bullet_Emitter;
    public GameObject Bullet;
    public float Bullet_Forward_Force;
    public AudioSource PlayerBeam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown("space"))
        {
            PlayerBeam.Play();

            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

            Destroy(Temporary_Bullet_Handler, 3.0f);
        }
	}
}
