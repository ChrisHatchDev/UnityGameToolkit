using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollision : MonoBehaviour {

    public bool OneTime;
    private bool _triggered = false;

    public UnityEvent Enter;
    public UnityEvent Stay;
    public UnityEvent Exit;
    public UnityEvent EnterGood;

    private void OnCollisionEnter(Collision collision)
    {
        if (!_triggered && collision.gameObject.tag == "Bad")
        {
            Enter.Invoke();
            if(OneTime)
                _triggered = true;
        }

        else if (!_triggered && collision.gameObject.tag == "Good")
        {
            EnterGood.Invoke();
            if (OneTime)
                _triggered = true;
        }
    }

  

    private void OnCollisionStay(Collision collision)
    {
        if (!_triggered)
        {
            Stay.Invoke();
            if (OneTime)
                _triggered = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (!_triggered)
        {
            Exit.Invoke();
            if (OneTime)
                _triggered = true;
        }
    }
}
