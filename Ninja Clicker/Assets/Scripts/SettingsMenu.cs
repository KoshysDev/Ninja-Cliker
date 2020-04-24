using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public GameObject SoundSource;
    public Toggle MusicTogle;
    public Toggle SoundToggle;
    public float CurrentVolume;

    public void SaveSettings()
    {
        SaveDataScript.SaveSettings(this);
    }

    public void LoadSettings()
    {
        PlayerSettingsData data = SaveDataScript.LoadSettings();
        MusicTogle.isOn = data.MusicTogle;  
        SoundToggle.isOn = data.SoundToggle;
        CurrentVolume = data.CurrentVolume;
        audioMixer.SetFloat("volume", CurrentVolume);
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
        CurrentVolume = volume;
    }

    public void TurnOffTheMusic()
    {
        if(MusicTogle.GetComponent<Toggle>().isOn == false)
        {
            SoundSource.SetActive(false);
        }
        else
        {
            SoundSource.SetActive(true);
        }
    }

    public void TurnOffTheSound()
    {
        if (SoundToggle.GetComponent<Toggle>().isOn == false)
        {
            MainClick.IfSoundOn = false;
        }
        else
        {
            MainClick.IfSoundOn = true;
        }
    }
}
