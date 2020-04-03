using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string AudioPref = "AudioPref";
    private static readonly string EffectPref = "EffectPref";
    private float AudioVolumeFloat, EffectVolumeFloat;
    public AudioSource Audio;
    public AudioSource[] effects;
    void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        AudioVolumeFloat = PlayerPrefs.GetFloat(AudioPref);
        EffectVolumeFloat = PlayerPrefs.GetFloat(EffectPref);
        
        Audio.volume = AudioVolumeFloat;

        for (int i = 0; i < effects.Length; i++)
        {
            effects[i].volume = EffectVolumeFloat;
        }
    }

}
