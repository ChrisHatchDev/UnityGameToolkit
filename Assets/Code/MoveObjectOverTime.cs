using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectOverTime : MonoBehaviour {

    [Tooltip("Requires a Rigidbody on this GameObject")]
    public bool PhysicsBased;
    private Rigidbody _rigid;

    [Tooltip("You can define the direction using this Vector 3")]
    public Vector3 MoveSpeed;

	void Start () {
        if(PhysicsBased)
            _rigid = GetComponent<Rigidbody>();
	}
	
	void Update () {

        if (PhysicsBased)
        {
            _rigid.position += MoveSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += MoveSpeed * Time.deltaTime;
        }
	}
}
