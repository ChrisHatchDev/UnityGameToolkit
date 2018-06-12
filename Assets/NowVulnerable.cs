using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowVulnerable : MonoBehaviour {
    public Sprite Sprite1;
    public Sprite Sprite2;
    public SpriteRenderer spriteRenderer;
    public PlayerController PlayerControl;
	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerControl.Invincible == true) // If the space bar is pushed down
        {
            ChangeTheDamnSprite(); // call method to change sprite
        }
    }
    void ChangeTheDamnSprite()
    {
        if (spriteRenderer.sprite == Sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = Sprite2;
        }
        else
        {
            spriteRenderer.sprite = Sprite1; // otherwise change it back to sprite1
        }
    }
}
