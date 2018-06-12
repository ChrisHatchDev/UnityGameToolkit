using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public float Score = 0;
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

    public void CheckForWin(int scoreToWin)
    {
        IsWinScoreAchieved(scoreToWin);
    }

    public bool IsWinScoreAchieved(int scoreToWin)
    {
        if (Score >= scoreToWin)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void WinGame (){

        ScoreText.text = "You Won!";

    }
}
