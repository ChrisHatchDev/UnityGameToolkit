using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCollison : MonoBehaviour {
    public Canvas EndGame;
    public int StrikesREF;

	// Use this for initialization
	void Start () {
        EndGame.enabled = false;
        StrikesREF = GameObject.Find("ColorCube").GetComponent<cubeScript>().strikes;
    }

    // Update is called once per frame

    void Update () {

        if (StrikesREF >= 3)
        {
            Debug.Log("dude");
            EndGame.enabled = true;

        }



    }

    private void OnTriggerEnter(Collider other)
    {
        EndGame.enabled = true;
    }

}

