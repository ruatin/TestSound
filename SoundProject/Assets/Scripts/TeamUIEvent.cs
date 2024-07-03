using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class TeamUIEvent : MonoBehaviour
{
    [SerializeField] private EventReference teamUiSound;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("sound play");
            AudioManager.instance.PlayOneShot(teamUiSound,transform.position);
        }
    }
}
