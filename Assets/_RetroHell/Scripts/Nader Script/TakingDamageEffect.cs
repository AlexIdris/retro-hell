using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TakingDamageEffect : MonoBehaviour
{
    
    public Player_Control Player_Control;
    public float intensity = 0f;
    PostProcessVolume PPVolume;
    public Vignette vignette;
    public ColorParameter vignetteColor;
    public Color vignetterColor = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        PPVolume = GetComponent<PostProcessVolume>();
        PPVolume.profile.TryGetSettings<Vignette>(out vignette);

        vignette.enabled.Override(false);
    }
    public IEnumerator BloodScreenEffect()
    {
        intensity = 0.5f;

        vignette.enabled.Override(true);
        vignette.intensity.Override(0.4f);
        yield return new WaitForSeconds(0.5f);
        while (intensity> 0f) 
        {
            intensity -= 0.05f;

            if (intensity < 0f)
            {
                intensity = 0f;
            }

            vignette.intensity.Override(intensity);
            yield return new WaitForSeconds(0.1f);
        }

        vignette.enabled.Override(false);
        yield break;
    }
}
