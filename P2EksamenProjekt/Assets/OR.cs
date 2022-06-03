using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OR : MonoBehaviour
{
    public abstract void MethodOne();
}

public class ClassOne : OR
{
    public override void MethodOne()
    {
        Debug.Log("2");
    }
}