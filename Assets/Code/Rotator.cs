using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float Speed;
	
	void Update () {

        transform.Rotate(new Vector3(0, Speed, 0));

	}
}
