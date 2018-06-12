using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeScript : MonoBehaviour {
    public Material BaseMat, Black, White;
    public string ColorTag, PlayerTagREF, GameState;
    public Text OpisitesText;


	// Use this for initialization
	void Start () {
        PlayerTagREF = GameObject.Find("Player").GetComponent<PlayerControls>().PlayerTag;
        ColorTag = "White";
        StartCoroutine(ToWhite());
        StartCoroutine(Alike());

    }

    // Update is called once per frame
    void Update ()
    {


        if (GameState == "Alike" && Input.GetKeyDown("space"))
        {
            if (PlayerTagREF == ColorTag || PlayerTagREF == "Default")
            {
                Debug.Log("Nice !");
                PlayerTagREF = ColorTag;
            }
            else
            {

                Debug.Log("Too Bad");
                PlayerTagREF = ColorTag;

            }




        }

        if (GameState == "Opposites" && Input.GetKeyDown("space"))
        {
            if (PlayerTagREF != ColorTag || PlayerTagREF == "Default")
            {
                Debug.Log("Nice !");
                PlayerTagREF = ColorTag;

            }
            else
            {
                Debug.Log("Too Bad");
                PlayerTagREF = ColorTag;

            }


        }


    }


    IEnumerator ToBlack()
    {
        ColorTag = "Black";
        BaseMat.color = Black.color;
        yield return new WaitForSecondsRealtime(2.5f);
        StartCoroutine(ToWhite());

    }

    IEnumerator ToWhite()
    {

        ColorTag = "White";
        BaseMat.color = White.color;
        yield return new WaitForSecondsRealtime(2.5f);
        StartCoroutine(ToBlack());
    }

    IEnumerator Alike()
    {

        OpisitesText.text = "ALIKE";
        GameState = "Alike";

        yield return new WaitForSecondsRealtime(5.0f);
        StartCoroutine(Oppisite());
        Debug.Log("Alike");
    }

    IEnumerator Oppisite()
    {
        OpisitesText.text = "OPPOSITES";

        GameState = "Opposites";
        yield return new WaitForSecondsRealtime(5.0f);
        StartCoroutine(Alike());
        Debug.Log("Opposites");

    }


}
