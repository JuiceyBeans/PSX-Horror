using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlightBeam;
    public GameObject indicatorOn;
    public GameObject indicatorOff;

    public AudioSource turnOn;
    public AudioSource turnOff;
    
    public bool on;
    public bool off;

    void Start()
    {
        off = true;
        flashlightBeam.SetActive(false);
        indicatorOff.SetActive(true);
        indicatorOn.SetActive(false);
    }

    void Update()
    {
        if(off && UnityEngine.InputSystem.Keyboard.current.fKey.wasPressedThisFrame)
        {
            flashlightBeam.SetActive(true);
            indicatorOff.SetActive(false);
            indicatorOn.SetActive(true);
            turnOn.Play();
            off = false;
            on = true;
        }
        else if (on && UnityEngine.InputSystem.Keyboard.current.fKey.wasPressedThisFrame)
        {
            flashlightBeam.SetActive(false);
            indicatorOff.SetActive(true);
            indicatorOn.SetActive(false);
            turnOff.Play();
            off = true;
            on = false;
        }
    }
}