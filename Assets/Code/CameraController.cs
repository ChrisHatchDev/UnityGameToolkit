using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform CamTransform;
    public float ShakeDuration = 0f;
    public float ShakeAmount = 1.7f;
    public float DecreaseFactor = 1.0f;

    Vector3 OriginalPos;

    void Awake()
    {
        if (CamTransform == null)
        {
            CamTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable()
    {
        OriginalPos = CamTransform.localPosition;
    }

    void Update()
    {
        if (ShakeDuration > 0)
        {
            CamTransform.localPosition = OriginalPos + Random.insideUnitSphere * ShakeAmount;

            ShakeDuration -= Time.deltaTime * DecreaseFactor;
        }
        else
        {
            ShakeDuration = 0f;
            CamTransform.localPosition = OriginalPos;
        }
    }

    public void CameraShake()
    {
        ShakeDuration += 0.1f;
    }
}