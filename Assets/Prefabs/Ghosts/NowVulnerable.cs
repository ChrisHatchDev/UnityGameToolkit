using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NowVulnerable : MonoBehaviour {
    public Sprite Sprite1;
    public Sprite Sprite2;
    public SpriteRenderer spriteRenderer;
    public PlayerController PlayerControl;
    public GameObject Player;
    
	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Player = GameObject.FindWithTag("Player");
        PlayerControl = Player.GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (PlayerControl.Invincible == true) // If the space bar is pushed down
        {
            Vunerable (); // call method to change sprite
        }
        if (PlayerControl.Invincible == false)
        {
            Immune();
        }
    }
    void Vunerable()
    {
        if (spriteRenderer.sprite == Sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = Sprite2;
            
        }
    }
    void Immune()
    { 
        if (spriteRenderer.sprite == Sprite2)
        {
            spriteRenderer.sprite = Sprite1; // otherwise change it back to sprite1
        }
    }

}
