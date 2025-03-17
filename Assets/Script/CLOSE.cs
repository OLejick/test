using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLOSE : MonoBehaviour
{
    public GameObject _gameObject;
    public float delay = 0.2f;
    public void PlaySoundAndLoad()
    {
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        _gameObject.SetActive(false);
    }
}
