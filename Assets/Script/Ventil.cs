using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventil : MonoBehaviour
{
    public float rotationSpeed = 10f; // �������� �������� � �������� � �������

    void Update()
    {
        // ������������ ������ ������ ��� Z �� rotationSpeed �������� � �������
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
