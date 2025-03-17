using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventil : MonoBehaviour
{
    public float rotationSpeed = 10f; // Скорость вращения в градусах в секунду

    void Update()
    {
        // Поворачиваем объект вокруг оси Z на rotationSpeed градусов в секунду
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
