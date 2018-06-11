using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {

    public float DestroyDelay;

	void Start () {
        Invoke("DestroyThis", DestroyDelay);
	}
	
	void DestroyThis()
    {
        Destroy(gameObject);
    }
}
