using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UISwapping : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {      
        Shader.SetGlobalFloat("_Transition", Mathf.PingPong(Time.time * 0.6f, 1.8f) -0.3f);
        Shader.SetGlobalFloat("_FlipTransition", Mathf.PingPong(Time.time * 0.3f, 0.5f) );
    }
}
