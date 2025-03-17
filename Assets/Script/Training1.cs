using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training1 : MonoBehaviour
{
    public List<GameObject> text1;
    public GameObject gObject;
    public GameObject gObject2;
    public GameObject gObject3;
    private int count = 0;

    public void TextTrans()
    {
        if (count == 0)
        {
            text1[7].SetActive(false);
            gObject2.SetActive(false);
            gObject3.SetActive(false);
            gObject.SetActive(true);
            text1[1].SetActive(false);
            count++;
        }
    }
}
