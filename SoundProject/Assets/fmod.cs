using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fmod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FMODUnity.RuntimeManager.CreateInstance ("event:/W/W_BGM_1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
