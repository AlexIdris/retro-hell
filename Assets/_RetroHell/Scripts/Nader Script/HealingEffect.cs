using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class HealingEffect : MonoBehaviour
{
    public Player_Control Player_control;
    public float intensity = 0f;
    PostProcessVolume PPVolume1;
    public Vignette GreenScreen;
    // Start is called before the first frame update
    void Start()
    {
        PPVolume1 = GetComponent<PostProcessVolume>();
        PPVolume1.profile.TryGetSettings<Vignette>(out GreenScreen);

        GreenScreen.enabled.Override(false);
    }
    public IEnumerator GreenHealingEffect()
    {
        intensity = 0.5f;

        GreenScreen.enabled.Override(true);
        GreenScreen.intensity.Override(0.4f);
        yield return new WaitForSeconds(0.5f);
        while (intensity > 0f)
        {
            intensity -= 0.05f;

            if (intensity < 0f)
            {
                intensity = 0f;
            }

            GreenScreen.intensity.Override(intensity);
            yield return new WaitForSeconds(0.1f);
        }

        GreenScreen.enabled.Override(false);
        yield break;
    }
}
