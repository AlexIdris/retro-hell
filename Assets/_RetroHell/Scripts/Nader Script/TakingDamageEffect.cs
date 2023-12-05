using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TakingDamageEffect : MonoBehaviour
{
    
    public Player_Control Player_Control;
    public float intensity = 0f;
    PostProcessVolume PPVolume;
    Vignette BloodScreen;
    // Start is called before the first frame update
    void Start()
    {
        PPVolume= GetComponent<PostProcessVolume>();
        PPVolume.profile.TryGetSettings<Vignette>(out BloodScreen);

       BloodScreen.enabled.Override(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*  if (Player_Control.playercurrentHealth--)
          {
             StartCoroutine(BloodScreenEffect());
          }*/

        if (Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(BloodScreenEffect());
        }
            
    }
        

 
    public IEnumerator BloodScreenEffect()
    {
        intensity = 0.5f;

        BloodScreen.enabled.Override(true);
        BloodScreen.intensity.Override(0.4f);
        yield return new WaitForSeconds(0.4f);
        while (intensity> 0f) 
        {
            intensity -= 0.01f;

            if (intensity < 0f)
            {
                intensity = 0f;
            }

            BloodScreen.intensity.Override(intensity);
            yield return new WaitForSeconds(0.1f);
        }

        BloodScreen.enabled.Override(false);
        yield break;
    }
}
