using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float LaneWidth = 1.1f;
    public int NumberOfLanes = 3;

    public int Health = 3;
    public Text HealthText;
    public int AmmoCount = 0;
    public Text AmmoText;
    public GameObject Projectile;
    public Vector3 SpawnOffset;


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
                Shoot();
            }
        }

        HealthText.text = "Health " + Health.ToString();
        AmmoText.text = "Ammo " + AmmoCount.ToString() + "/3";
    }

    //Movement
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

    //Shooting
    void Shoot()
    {
        if (AmmoCount > 0)
        {
            Instantiate(Projectile, transform.position + SpawnOffset, Quaternion.identity);          
            AmmoCount--;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ammo" && AmmoCount < 3)
        {
            AmmoCount++;
            Destroy(collision.gameObject);
        }
    }

    //Health
    public void GotHit()
    {
        if(Health > 0)
        {
            Health--;
        }
    }
}
