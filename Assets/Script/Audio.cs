//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Audio : MonoBehaviour
//{
//    public GameObject _gameObject;
//    public AudioSource _audioSource;
//    [HideInInspector] public ReadyComputer IsReady;
//    [HideInInspector] public int value;
    

//    public void Check()
//    {
//        if (IsReady != null)
//            value = IsReady.ifcount;
//        if (value == 12)
//            _audioSource.PlayOneShot(_audioSource.clip);
//    }

//    public void OffPlay()
//    {
//        if (value < 12)
//            _audioSource.Stop();
//    }
//}
