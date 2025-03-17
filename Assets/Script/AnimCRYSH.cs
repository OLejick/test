using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimCRYSH : MonoBehaviour
{
    public GameObject _gameObject;
    public GameObject _gameObject1;
    public GameObject _gameObject2;
    public GameObject _gameObject56;
    public GameObject _gameObject65;
    public float delay = 0.2f;

    public void PlaySoundAndLoad()
    {

        _gameObject2.SetActive(false);
        _gameObject.SetActive(true);
        _gameObject1.SetActive(true);
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        _gameObject.SetActive(false);
        _gameObject1.SetActive(false);
        _gameObject56.SetActive(true);
        _gameObject65.SetActive(true);
    }
}
