using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody Rigid;
    public float JumpForce;

    public void Jump()
    {
        Rigid.AddForce(transform.up * JumpForce, ForceMode.Impulse);
    }
}
