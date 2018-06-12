using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class TimeLeft : MonoBehaviour
{


    public int timeLeft = 60; //Seconds Overall
    public Text countdown; //UI Text Object


    // Use this for initialization
    void Start()
    {

        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right


    }

    // Update is called once per frame
    void Update()
    {

        countdown.text = ("" + timeLeft); //Showing the Score on the Canvas
    }
    //Simple Coroutine
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;


        }
    }
}