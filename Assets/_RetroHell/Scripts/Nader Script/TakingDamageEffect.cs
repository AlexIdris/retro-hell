using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TakingDamageEffect : MonoBehaviour
{
    
    public Player_Control Player_Control;
    float intensity = 0f;
    PostProcessVolume PPVolume;
    Vignette vignette;
    public Color vignetterColor = Color.red;
    [SerializeField] float masseffect;
    // Start is called before the first frame update

    Color lhjdfj;
    void Start()
    {
        PPVolume = GetComponent<PostProcessVolume>();
        PPVolume.profile.TryGetSettings<Vignette>(out vignette);

        vignette.enabled.Override(false);
    }
    public IEnumerator BloodScreenEffect(Color vignetteColor)
    {
        intensity = masseffect;
        vignette.color.Override(vignetteColor);
        vignette.enabled.Override(true);
        vignette.intensity.Override(masseffect);
        yield return new WaitForSeconds(masseffect);
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
