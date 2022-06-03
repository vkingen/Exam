using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // why serializable?
public class ItemData
{
    public bool[] itemsUnlocked;

    public ItemData(ScanningManager scanningManager)
    {
        itemsUnlocked = scanningManager.scannedObjects;
    }
}
