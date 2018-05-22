using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollision : MonoBehaviour {

    public bool OneTime;
    private bool _triggered;

    public UnityEvent Enter;
    public UnityEvent Stay;
    public UnityEvent Exit;

    private void OnCollisionEnter(Collision collision)
    {
        if (!_triggered)
        {
            Enter.Invoke();
            _triggered = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!_triggered)
        {
            Stay.Invoke();
            _triggered = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (!_triggered)
        {
            Exit.Invoke();
            _triggered = true;
        }
    }
}
