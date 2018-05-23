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

    public void TickUpScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }

    public void CheckForWin()
    {
        IsWinScoreAchieved();
    }

    public bool IsWinScoreAchieved()
    {
        if (Score >= 1)
        {
            ScoreText.text = "Won!";
            return true;
        }
        else
        {
            return false;
        }
    }
}
