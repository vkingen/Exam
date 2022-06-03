using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// This script has taken inspiration from : https://www.youtube.com/watch?v=XOjd_qU2Ido
public static class SaveAndLoadSystem
{
    static string pathName = "scanningData.vking";

    public static void SaveData(ScanningManager scanningManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + Path.DirectorySeparatorChar + pathName;
        FileStream stream = new FileStream(path, FileMode.Create);

        ItemData data = new ItemData(scanningManager);

        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static ItemData LoadData()
    {
        string path = Application.persistentDataPath + Path.DirectorySeparatorChar + pathName;
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ItemData data = formatter.Deserialize(stream) as ItemData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Save file not found at " + path);
            return null;
        }
    }
}
