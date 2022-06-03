using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saving : MonoBehaviour
{
    ScanningManager _scanningManager;

    public void Start()
    {
        _scanningManager = FindObjectOfType<ScanningManager>();
        SaveAndLoadSystem.SaveData(_scanningManager);
    }
}
