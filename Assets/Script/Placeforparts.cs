using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeforparts : MonoBehaviour
{
    public List<GameObject> IncludedObjects = new List<GameObject>();
    public void EnableConnectors()
    {
        foreach (GameObject obj in IncludedObjects)
        {
            obj.SetActive(true);
        }
    }
}
