using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string AudioPref = "AudioPref";
    private float AudioVolumeFloat;
    public AudioSource Audio;
    void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        AudioVolumeFloat = PlayerPrefs.GetFloat(AudioPref);
        
        Audio.volume = AudioVolumeFloat;
    }

}
