using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TB : MonoBehaviour
{
    public GameObject _gameObject1;
    public GameObject _gameObject2;
    public GameObject _gameObject3;
    public GameObject _gameObject4;
    public GameObject _gameObject5;
    public GameObject _gameObject6;
    [HideInInspector] public int count = 0;

    public void Activ()
    {
        if (count == 1)
        {
            _gameObject1.SetActive(true);
            _gameObject2.SetActive(true);
            _gameObject3.SetActive(true);
            _gameObject5.SetActive(true);
            _gameObject6.SetActive(true);
        }
        count++;

        if (count == 5)
        {
            _gameObject4.SetActive(true);
        }
    }
}
