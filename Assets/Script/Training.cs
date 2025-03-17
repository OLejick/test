using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    public List<GameObject> text;
    public GameObject gObject;
    public GameObject gObject2;
    public GameObject gObject3;
    public GameObject gObject4;
    private int count = 0;
    private int count2 = 0;
    private int count3 = 0;
    private int count4 = 0;
    private int count5 = 0;

    public void TextTrans1()
    {
            for (int b = 0; b < text.Count; b++)
            {
                if (count5 == b)
                {
                    if (count4 == 0)
                    {
                        gObject4.SetActive(true);
                        count4 = 1;
                    }
                    text[b].SetActive(false);
                    text[b + 1].SetActive(true);
                } 
            }
            count5++;
            if (count4 == 1 && count5 == 5)
            {
                gObject2.SetActive(true);
                count4 = 0;
                gObject.SetActive(false);
            }
    }

    public void TextTrans()
    {
        if (count2 == 1)
        {
            for (int j = 0; j < text.Count; j++)
            {
                if (count3 == j)
                {
                    text[j].SetActive(false);
                    text[j + 1].SetActive(true);
                }
            }
            count3++;
            if (count3 == 7)
            {
                text[7].SetActive(true);
                gObject.SetActive(false);
                gObject3.SetActive(false);
                gObject2.SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < text.Count; i++)
            {
                if (count == i)
                {
                    if (count4 == 0)
                    {
                        gObject4.SetActive(true);
                        count4 = 1;
                    }
                    text[i].SetActive(false);
                    text[i + 1].SetActive(true);
                }
            }
            count++;
            if (count == 7)
            {
                text[7].SetActive(true);
                gObject.SetActive(false);
                gObject2.SetActive(true);
                gObject3.SetActive(true);
                count2 = 1;
            }
        }
        

    }
}
