using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour {

    public KeyCode Key;
    public UnityEvent InputClick;

    public bool TapScreen;
    public UnityEvent TouchTap;
	
	void Update () {

        if (TapScreen)
        {
            if(Input.touchCount > 0)
            {
                Touch _touch = Input.GetTouch(0);
                if(_touch.phase == TouchPhase.Began)
                {
                    TouchTap.Invoke();
                }
            }
        }

        if (Input.GetKeyDown(Key))
        {
            InputClick.Invoke();
        }
	}
}
