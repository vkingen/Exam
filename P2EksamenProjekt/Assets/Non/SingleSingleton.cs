using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SingleSingleton
{
    public static int totalHealth = 100;
    public static int health = 2;

    public static void AddHealth()
    {
        totalHealth += health;
    }
}
