using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    //public AnimationClip JumptoRight, JumptoLeft;
    bool isRight = false;
    Animator Anim, LeftAnim, RightAnim;
    public Material CurrentMat, ColorReference;
    public string PlayerTag = "Default", ColorTagREF;


	// Use this for initialization
	void Start ()
    {
        ColorTagREF = GameObject.Find("ColorCube").GetComponent<cubeScript>().ColorTag;

        CurrentMat.color = ColorReference.color;
        Anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        if (Anim = null)
        {
            Debug.Log("Anim Is Null");

        }
        Debug.Log("dag on!!");
	}

    // Update is called once per frame
    void Update()
    {
        Anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        LeftAnim = GameObject.FindGameObjectWithTag("Platform").GetComponent<Animator>();
        RightAnim = GameObject.Find("RightPlatform").GetComponent<Animator>();


        if (Input.GetKeyDown("space") && Anim.GetCurrentAnimatorStateInfo(0).IsName("IdleLeft"))
        
            {

            CurrentMat.color = GameObject.Find("ColorCube").GetComponent<cubeScript>().BaseMat.color;

            LeftAnim.SetBool("IsLeft", false);
            RightAnim.SetBool("IsRight", true);

            Anim.ResetTrigger("JumpingLeft");

            Anim.SetTrigger("JumpingRight");


                Debug.Log("loser");

            

            }


        

        if (Input.GetKeyDown ("space") && Anim.GetCurrentAnimatorStateInfo(0).IsName("IdleRight"))
        {

            CurrentMat.color = GameObject.Find("ColorCube").GetComponent<cubeScript>().BaseMat.color;

            LeftAnim.SetBool("IsLeft", true);
            RightAnim.SetBool("IsRight", false);

            Anim.ResetTrigger("JumpingRight");

            Anim.SetTrigger("JumpingLeft");


        }

      
    }

}
