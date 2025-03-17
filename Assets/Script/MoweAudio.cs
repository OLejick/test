using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class MoweAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public float minSpeedForSound = 0.5f;
    public AudioClip walkSound;
    private Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        float currentSpeed = Vector3.Distance(transform.position, lastPosition) / Time.deltaTime;
        lastPosition = transform.position;

        if (currentSpeed > minSpeedForSound)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(walkSound);
            }
        }
        else
        {
            if (audioSource != null)
                audioSource.Stop();
        }
    }
}

