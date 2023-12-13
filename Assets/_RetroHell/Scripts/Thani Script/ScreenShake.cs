using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public bool hit;
    public float timeLimit = 1f;

    public AnimationCurve shakingSpeed;

    void Update()
    {
        if (hit == true)
        {
            hit = false;
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        Vector3 startPosition = transform.position;
        float timePassed = 0f;
        while (timePassed < timeLimit)
        {
            timePassed += Time.deltaTime;
            float shakingStrength = shakingSpeed.Evaluate(timePassed / timeLimit);
            transform.position = startPosition + Random.insideUnitSphere * shakingStrength;
            yield return null;
        }

        transform.position = startPosition;
    }
}
