using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string AudioPref = "AudioPref";
    private static readonly string EffectPref = "EffectPref";
    private int firstPlayInt;
    public Slider AudioVolumeSlider, EffectVolumeSlider;
    private float AudioVolumeFloat, EffectVolumeFloat;
    public AudioSource Audio;
    public AudioSource[] effects;
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if (firstPlayInt == 0)
        {
            AudioVolumeFloat = 2.5f;
            EffectVolumeFloat = 5f;
            AudioVolumeSlider.value = AudioVolumeFloat;
            EffectVolumeSlider.value = EffectVolumeFloat;
            PlayerPrefs.SetFloat(AudioPref, AudioVolumeFloat);
            PlayerPrefs.SetFloat(EffectPref, EffectVolumeFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            AudioVolumeFloat = PlayerPrefs.GetFloat(AudioPref);
            AudioVolumeSlider.value = AudioVolumeFloat;
            EffectVolumeFloat = PlayerPrefs.GetFloat(EffectPref);
            EffectVolumeSlider.value = EffectVolumeFloat;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(AudioPref, AudioVolumeSlider.value);
        PlayerPrefs.SetFloat(EffectPref, EffectVolumeSlider.value);
    }

    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        Audio.volume = AudioVolumeSlider.value;

        for(int i = 0; i < effects.Length; i++)
        {
            effects[i].volume = EffectVolumeSlider.value;
        }
    }
}
