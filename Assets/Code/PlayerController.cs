using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float LaneWidth = 1.1f;
    public int NumberOfLanes = 3;

    public int Health = 3;
    public Text HealthText;
    private bool hasJumped;
    public Rigidbody Rigid;
    public float JumpForce;


    // Use this for initialization
    void Start () {
		
	}

    public void Jump()
    {
        Rigid.AddForce(transform.up * JumpForce, ForceMode.Impulse);
        hasJumped = true;
    }


    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown("space") && hasJumped == false)
        {
            Jump();
        }


        if (Health > 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                MoveLeft();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                MoveRight();
            }
        }

        HealthText.text = "Health " + Health.ToString();
    }

    void MoveLeft()
    {
        int _movesToTheLeft = (int)(transform.position.x / 1.1f);
        //Debug.Log("Moves to the left =" + _movesToTheLeft);

        if(_movesToTheLeft > -NumberOfLanes/3)
            transform.position -= new Vector3(LaneWidth, 0, 0);

    }

    void MoveRight()
    {
        int _movesToTheRight = (int)(transform.position.x / 1.1f);
        //Debug.Log("Moves to the Right =" + _movesToTheRight);

        if (_movesToTheRight < NumberOfLanes/3)
            transform.position += new Vector3(LaneWidth, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            hasJumped = false;
        }
    }


    public void GotHit()
    {
        if(Health > 0)
        {
            Health--;
        }

    }
}
