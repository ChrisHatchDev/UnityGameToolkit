using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {

    public Transform TargetObj;
    public float FollowSpeed;

    private Vector3 _targetPOS;
	
	void Update () {
		
        if(transform.position.y <= _targetPOS.y - 1)
        {
            transform.position = transform.position + new Vector3(0, FollowSpeed * Time.deltaTime, 0);
            print("UP!");
        }
        else if (transform.position.y > _targetPOS.y + 1)
        {
            transform.position = transform.position - new Vector3(0, FollowSpeed * Time.deltaTime, 0);
            print("Down!");
        }

    }
}
