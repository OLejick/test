using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTr : MonoBehaviour
{
    public AudioSource audioSource;
    public float delay = 0.2f;

    public void PlaySoundAndLoad()
    {
        audioSource.PlayOneShot(audioSource.clip);
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(1);
    }
}
