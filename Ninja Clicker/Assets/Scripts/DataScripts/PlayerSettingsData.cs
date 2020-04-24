using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerSettingsData
{
    public bool MusicTogle;
    public bool SoundToggle;
    public float CurrentVolume;
    
    public PlayerSettingsData(SettingsMenu settings)
    {
        MusicTogle = settings.MusicTogle.isOn;
        SoundToggle = settings.SoundToggle.isOn;
        CurrentVolume = settings.CurrentVolume;
    }
}
