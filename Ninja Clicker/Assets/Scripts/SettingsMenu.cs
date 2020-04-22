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

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
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
