using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public float timeLimit = 1f;

    public AnimationCurve shakingSpeed;

    public IEnumerator Shake(float timeLimit, float magnitude)
    {
        Vector3 startPosition = transform.localPosition;
        float timePassed = 0.0f;
        while (timePassed < timeLimit)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, startPosition.z);

            timePassed = Time.deltaTime;
            yield return null;
        }

        transform.position = startPosition;
    }
}
