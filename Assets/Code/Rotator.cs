using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float Speed;

    public bool PhysicsBased;
    private Rigidbody _rigid;

    private void Start()
    {
        if(PhysicsBased){
            _rigid = GetComponent<Rigidbody>();
        }
    }

    void Update () {
        
        //Speed is multiplied by 10 to make entering numbers for speed be more reasonable such as 5, 7, 15 instead of 50, 70, 150 speed values
        if(PhysicsBased){
            _rigid.rotation = Quaternion.Euler(_rigid.rotation.eulerAngles + new Vector3(0, (Speed * 10) * Time.deltaTime, 0));
        }else{
            transform.rotation = Quaternion.Euler(_rigid.rotation.eulerAngles + new Vector3(0, (Speed * 10) * Time.deltaTime, 0));
        }

	}
}
