using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float LaneWidth = 1.1f;
    public int NumberOfLanes = 3;
    public GameManager Manager;
    public int Health = 3;
    public Text HealthText;
    public bool Invincible;

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
    public void OnCollisionEnter(Collision other)
    {
        GotHit(other);
        /*if (collision.gameObject.tag == "WhitePellet")
        {
            Debug.Log("Waka");
            Manager.TickUpWhitePellets();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "BluePellet")
        {
            Debug.Log("WAKA WAKA WAKA");
            Manager.TickUpBluePellets();
            Destroy(collision.gameObject);
        }
        else
        {
            GotHit();
        }*/
    }
    public void GotHit(Collision other)
    {
        if(other.gameObject.tag != "WhitePellet" && other.gameObject.tag != "BluePellet" && Health > 0)
        {
            Health--;
        }
        if(other.gameObject.tag == "WhitePellet")
        {
            Debug.Log("Waka");
            Manager.TickUpWhitePellets();
            //Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BluePellet")
        {
            Debug.Log("WAKA WAKA WAKA");
            Manager.TickUpBluePellets();
            Invincible = true;
            //Destroy(other.gameObject);
        }
    }
    public void Waka()
    {
        if (tag == "WhitePellet")
        {
            Manager.TickUpWhitePellets();
        }
        if (tag == "BluePellet")
        {
            Manager.TickUpBluePellets();
        }
    }

    
}
