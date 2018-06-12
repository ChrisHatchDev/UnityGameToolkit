using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCollison : MonoBehaviour {
    public Canvas EndGame;

	// Use this for initialization
	void Start () {
        EndGame.enabled = false;

    }

    // Update is called once per frame

    void Update () {


    
		
	}

    private void OnTriggerEnter(Collider other)
    {
        EndGame.enabled = true;
    }

}

