using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    [SerializeField] private GameObject end1, end2;

    private LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
    }

    private void Update()
    {
         lineRenderer.SetPosition(0, end1.transform.position);

        

        
        lineRenderer.SetPosition(1, end2.transform.position);
    }

}
