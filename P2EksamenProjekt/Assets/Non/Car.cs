using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
   public Car(int _numberOfWheels, float _maxSpeed)
    {
        _numberOfWheels = 4;
        _maxSpeed = 120;
    }



    private void Start()
    {
        Car car1 = new Car(3,190);
        Debug.Log(car1);
    }
}
