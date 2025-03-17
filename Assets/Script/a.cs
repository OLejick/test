using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject gameObject12;

    public void Upwqsa()
    {
        // Проверяем, нажата ли клавиша (например, пробел)
        if (gameObject)
        {
            // Проверяем, воспроизводится ли звук
            if (!audioSource.isPlaying)
            {
                // Запускаем звук
                audioSource.Play();
            }
            else
            {
                audioSource.Play();

            }
        }
    }

}
