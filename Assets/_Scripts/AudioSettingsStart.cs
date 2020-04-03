using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsStart : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string AudioPref = "AudioPref";
    private static readonly string EffectPref = "EffectPref";
    private float AudioVolumeFloat, EffectVolumeFloat;
    public AudioSource Audio;
    public AudioSource[] effects;
    private int firstPlayInt;

    void Start()
    {
        UnityEngine.Debug.Log("HI");
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        UnityEngine.Debug.Log(firstPlayInt);
        if (firstPlayInt == 0)
        {
            AudioVolumeFloat = 2.5f;
            EffectVolumeFloat = 5f;
            PlayerPrefs.SetFloat(AudioPref, AudioVolumeFloat);
            PlayerPrefs.SetFloat(EffectPref, EffectVolumeFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            AudioVolumeFloat = PlayerPrefs.GetFloat(AudioPref);
            EffectVolumeFloat = PlayerPrefs.GetFloat(EffectPref);
        }
    }

    void Awake()
    {
        UnityEngine.Debug.Log("HI");
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
