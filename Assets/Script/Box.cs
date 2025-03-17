using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.Threading.Tasks;

public class Box : MonoBehaviour
{
    [SerializeField] private GameObject GameObject;
    public void Disable()
    {
        GameObject.SetActive(false);
    }
    public void ONDisable()
    {
        GameObject.SetActive(true);
    }

    void DisableObjectAndChildren(GameObject obj)
    {
        obj.SetActive(true);

        foreach (Transform child in obj.transform)
        {
            DisableObjectAndChildren(child.gameObject);
        }

    }

    public void Disable2()
    {
        DisableObjectAndChildren(gameObject);
    }
}
