using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public IEnumerator Shake(float timeLimit)
    {
        float timePassed = 0f;
        float magnitude = 1f;

        while (timePassed < timeLimit)
        {
            float x = (Random.value - 0.5f) * magnitude;
            float y = (Random.value - 0.5f) * magnitude;
            float z = (Random.value - 0.5f) * magnitude;

            transform.localPosition = new Vector3(x, y, z);

            timePassed += Time.deltaTime;
            magnitude = (1 - (timePassed / timeLimit) * 1 - (timePassed / timeLimit));

            yield return null;
        }

        transform.localPosition = Vector3.zero;
    }

    //public float timeLimit = 1f;

    //public AnimationCurve shakingSpeed;

    //public IEnumerator Shake(float timeLimit, float magnitude)
    //{
    //Vector3 startPosition = transform.localPosition;
    //float timePassed = 0.0f;
    //while (timePassed < timeLimit)
    //{
    //float x = Random.Range(-1f, 1f) * magnitude;
    //float y = Random.Range(-1f, 1f) * magnitude;

    //transform.localPosition = new Vector3(x, y, startPosition.z);

    //timePassed = Time.deltaTime;
    //yield return null;
    //}

    //transform.position = startPosition;
    //}
}
