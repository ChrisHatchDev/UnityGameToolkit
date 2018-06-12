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

    private void OnCollisionEnter(Collision collision)
    {
        if (!_triggered)
        {
            Enter.Invoke();
            if(OneTime)
                _triggered = true;
        }
        if (collision.gameObject.name == "player") 
        {
            Destroy(this.gameObject);
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
