using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Delay());
    }

    private void AddH()
    {
        SingleSingleton.AddHealth();
        Debug.Log(SingleSingleton.totalHealth);
        
    }

    IEnumerator Delay()
    {
        AddH();
        yield return new WaitForSeconds(2);
        StartCoroutine(Delay());
    }
}
