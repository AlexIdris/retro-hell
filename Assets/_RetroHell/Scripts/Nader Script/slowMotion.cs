using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowMotion : MonoBehaviour
{
    bool slowMo=false;
    float slowMoSpeed =0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            slowMo=true;
            Time.timeScale= slowMoSpeed;
        }
    }
}
