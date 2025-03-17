using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TermopastaAnim : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public GameObject _gameObject;
    public GameObject _gameObject1;
    public GameObject _gameObject2;
    public GameObject _gameObject3;
    public GameObject _gameObject4;
    public float delay = 0.2f;

    public void PlaySoundAndLoad()
    {
        meshRenderer.enabled = false;
        _gameObject3.SetActive(false);
        _gameObject.SetActive(true);
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        _gameObject.SetActive(false);
        _gameObject2.SetActive(false);
        _gameObject1.SetActive(true);
        _gameObject4.SetActive(true);
    }

    void Start()
    {
        // �������� ��������� Mesh Renderer �� �������
        meshRenderer = GetComponent<MeshRenderer>();
    }
}
