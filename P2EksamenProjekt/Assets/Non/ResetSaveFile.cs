using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSaveFile : MonoBehaviour
{
    ScanningManager _scanningManager;

    public void ResetSavedData()
    {
        _scanningManager = FindObjectOfType<ScanningManager>();
        _scanningManager.scannedObjects = new bool[6];
        SaveAndLoadSystem.SaveData(_scanningManager);
    }
}
