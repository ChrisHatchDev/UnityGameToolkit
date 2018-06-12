using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderAnimator : MonoBehaviour {

    public float ScrollSpeed;
    public Renderer Rend;

	// Use this for initialization
	void Start ()
    {
        Rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float offset = Time.time * ScrollSpeed;
        Rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
	}
}
