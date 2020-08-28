using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace DataScripts
{
    public static class SaveDataScript
    {   
        public static void SaveSettings(SettingsMenu settings)
        {
            var formatter = new BinaryFormatter();
            var path = Application.persistentDataPath + "/SettingsData.ncs";
            var stream = new FileStream(path, FileMode.Create);

            var data = new PlayerSettingsData(settings);

            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static PlayerSettingsData LoadSettings()
        {
            var path = Application.persistentDataPath + "/SettingsData.ncs";
            if (File.Exists(path))
            {
                var formatter = new BinaryFormatter();
                var stream = new FileStream(path, FileMode.Open);

                var data = formatter.Deserialize(stream) as PlayerSettingsData;
                stream.Close();
                // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
                Debug.Log("Save file found in " + path);
                return data;
            }
            else
            {
                // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
                Debug.Log("Save file not found in " + path);
                return null;
            }
        }
    }
}
