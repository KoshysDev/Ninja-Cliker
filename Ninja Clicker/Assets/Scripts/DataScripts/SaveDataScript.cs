using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveDataScript
{   
   public static void SaveSettings(SettingsMenu settings)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/SettingsData.ncs";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerSettingsData data = new PlayerSettingsData(settings);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerSettingsData LoadSettings()
    {
        string path = Application.persistentDataPath + "/SettingsData.ncs";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerSettingsData data = formatter.Deserialize(stream) as PlayerSettingsData;
            stream.Close();
            Debug.Log("Save file found in " + path);
            return data;
        }
        else
        {
            Debug.Log("Save file not found in " + path);
            return null;
        }
    }
}
