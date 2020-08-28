namespace DataScripts
{
    [System.Serializable]
    public class PlayerSettingsData
    {
        public bool musicTogle;
        public bool soundToggle;
        public float currentVolume;
    
        public PlayerSettingsData(SettingsMenu settings)
        {
            musicTogle = settings.musicTogle.isOn;
            soundToggle = settings.soundToggle.isOn;
            currentVolume = settings.currentVolume;
        }
    }
}
