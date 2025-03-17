using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animation1 : MonoBehaviour
{
    public Animator animator;
    public float delay = 0.5f;
    public GameObject _gameObject;

    public void Anim()
    {
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        _gameObject.SetActive(false);
    }
}
