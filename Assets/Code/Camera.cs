using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * -Input.GetAxis("Mouse Y");
             transform.Rotate(v, h, 0);



		
	}
}
