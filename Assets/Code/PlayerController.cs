using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float LaneWidth = 1.1f;
    public float LaneHeight = 2.1f;
    public int NumberOfLanes = 3;

    public int Health = 3;
    public Text HealthText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

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
            if (Input.GetKeyDown(KeyCode.W))
            {
                MoveUpward();
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                MoveDown();
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
    void MoveUpward()
    {
        int _movesUpward = (int)(transform.position.y / 2.1f);


        if (_movesUpward < +NumberOfLanes / 2)
            transform.position += new Vector3(0, LaneHeight, 0);

    }
    void MoveDown()
    {
        int _movesDown = (int)(transform.position.y / 2.1f);


        if (_movesDown > -NumberOfLanes / 2)
            transform.position -= new Vector3(0, LaneHeight, 0);

    }


    void MoveRight()
    {
        int _movesToTheRight = (int)(transform.position.x / 1.1f);
        //Debug.Log("Moves to the Right =" + _movesToTheRight);

        if (_movesToTheRight < NumberOfLanes/3)
            transform.position += new Vector3(LaneWidth, 0, 0);
    }

    

    public void GotHit()
    {
        if(Health > 0)
        {
            Health--;
        }

    }
}
