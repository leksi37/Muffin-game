using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string AudioPref = "AudioPref";
    private int firstPlayInt;
    public Slider AudioVolumeSlider;
    private float AudioVolumeFloat;
    public AudioSource Audio;
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if (firstPlayInt == 0)
        {
            AudioVolumeFloat = 2.5f;
            AudioVolumeSlider.value = AudioVolumeFloat;
            PlayerPrefs.SetFloat(AudioPref, AudioVolumeFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            AudioVolumeFloat = PlayerPrefs.GetFloat(AudioPref);
            AudioVolumeSlider.value = AudioVolumeFloat;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(AudioPref, AudioVolumeSlider.value);
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
    }
}
