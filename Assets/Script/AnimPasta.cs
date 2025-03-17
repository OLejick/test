using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPasta : MonoBehaviour
{
  public void Rotate90Z()
  {
    Quaternion currentRotation = transform.rotation;
    Quaternion newRotation = Quaternion.Euler(currentRotation.eulerAngles + new Vector3(0, 0, 90));
    transform.rotation = newRotation;
  }
}
