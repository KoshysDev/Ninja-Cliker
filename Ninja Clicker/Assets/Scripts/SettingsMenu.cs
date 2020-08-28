using DataScripts;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public GameObject soundSource;
    public Toggle musicTogle;
    public Toggle soundToggle;
    public float currentVolume;

    public void SaveSettings()
    {
        SaveDataScript.SaveSettings(this);
    }

    public void LoadSettings()
    {
        // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        var data = SaveDataScript.LoadSettings();
        musicTogle.isOn = data.musicTogle;  
        soundToggle.isOn = data.soundToggle;
        currentVolume = data.currentVolume;
        audioMixer.SetFloat("volume", currentVolume);
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
        currentVolume = volume;
    }

    public void TurnOffTheMusic()
    {
        soundSource.SetActive(musicTogle.GetComponent<Toggle>().isOn != false);
    }

    public void TurnOffTheSound()
    {
        MainClick.IfSoundOn = soundToggle.GetComponent<Toggle>().isOn != false;
    }
}
