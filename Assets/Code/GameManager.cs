using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float Score = 0;
    public Text ScoreText;

    public bool UseTimeAsScore;
    public float TimeSurvived;

    public bool CheckForWinOnUpdate;
    public PlayerController PlayerControl;

    public bool GameHasEnded = false;

	// Use this for initialization
	void Start () {
        ScoreText.text = Score.ToString();
	}

    private void Update()
    {
        if (UseTimeAsScore)
        {
            TimeSurvived += Time.deltaTime;
            Score = TimeSurvived * 10;
            ScoreText.text = Score.ToString("000");
        }

        if (CheckForWinOnUpdate)
        {
            CheckPlayerHealth();
        }

        /* Touch Support
        if(Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                //I have tapped
            }
        }
        */

        if (Input.GetKeyDown(KeyCode.R) && GameHasEnded)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
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

    public void CheckPlayerHealth()
    {
        if(PlayerControl.Health <= 0)
        {
            PlayerControl.HealthText.gameObject.SetActive(false);
            ScoreText.text = "Game Over";
            Time.timeScale = 0;
            GameHasEnded = true;
        }
    }

    public bool IsWinScoreAchieved(int scoreToWin)
    {
        if (Score >= scoreToWin)
        {
            WinGame();
            GameHasEnded = true;
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
