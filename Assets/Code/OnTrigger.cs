using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTrigger : MonoBehaviour {

    public bool OneTime;
    private bool _triggered;

    public UnityEvent Enter;
    public UnityEvent Stay;
    public UnityEvent Exit;

    private void OnTriggerEnter(Collider other)
    {
        if (!_triggered)
        {
            Enter.Invoke();
            _triggered = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!_triggered)
        {
            Stay.Invoke();
            _triggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!_triggered)
        {
            Exit.Invoke();
            _triggered = true;
        }
    }

    private void OnValidate()
    {
        GetComponent<Collider>().isTrigger = true;
    }
}
