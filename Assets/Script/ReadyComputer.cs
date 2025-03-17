using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyComputer : MonoBehaviour
{
    public List<GameObject> qwwq;
    public List<GameObject> qwwq1;
    [HideInInspector] public static int isReady;
    public GameObject _monitor;
    public AudioSource _audioSource;
    public AudioClip walkSound2;
    [HideInInspector] public int ifcount = 2;
    [HideInInspector] public int ifcount1 = 0;
    [HideInInspector] public bool enable;
    //[SerializeField] private Material _monitorMaterial;
    void Start()
    {
        if (_audioSource != null)
        {
            // s
        }
        if (_monitor != null)
        {
            //
        }
    }


    public void EnableMonitor()
    {
        enable = ifcount % 2 != 0;
        if (isReady == 13 || isReady == 26)
        {
            if (!enable)
            {
                ifcount++;
                _audioSource.Play();
                _monitor.SetActive(true);
                foreach (var item in qwwq)
                {
                    item.SetActive(true);
                }
                foreach (var item1 in qwwq1)
                {
                    item1.SetActive(false);
                }
            }
            else if (enable)
            {
                ifcount++;
                _audioSource.Stop();
                _monitor.SetActive(false);
                foreach (var item in qwwq)
                {
                    item.SetActive(false);
                }
                foreach (var item1 in qwwq1)
                {
                    item1.SetActive(true);
                }

            }
        }

    }
    public void Ready()
    {
        isReady += 1;
        Debug.Log(isReady);
    }
    public void UnReady()
    {
        isReady -= 1;
        Debug.Log(isReady);
        if (_audioSource != null)
            _audioSource.Stop();
        _monitor.SetActive(false);
    }

}
