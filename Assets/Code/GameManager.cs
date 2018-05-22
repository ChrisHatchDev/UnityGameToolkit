using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public float Score;
    public Text ScoreText;

	// Use this for initialization
	void Start () {
        ScoreText.text = Score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TickUpScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
}
