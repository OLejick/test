using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Update()
    {
      // Обновляем позицию и вращение объекта
      transform.position = target.position + offset;
      transform.rotation = target.rotation;
    }
  }
