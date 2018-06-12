using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class collisionRevision : MonoBehaviour {
    public bool OneTime;
    private bool _triggered = false;

    public UnityEvent Enter;
    public UnityEvent Stay;
    public UnityEvent Exit;

    private void OnCollisionEnter(Collision collision)
    {
        if (!_triggered && collision.gameObject.tag != "Ground" && collision.gameObject.tag != "Coin")
        {
            Enter.Invoke();
            if (OneTime)
                _triggered = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!_triggered && collision.gameObject.tag != "Ground" && collision.gameObject.tag != "Coin")
        {
            Stay.Invoke();
            if (OneTime)
                _triggered = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (!_triggered && collision.gameObject.tag != "Ground" && collision.gameObject.tag != "Coin")
        {
            Exit.Invoke();
            if (OneTime)
                _triggered = true;
        }
    }


}
