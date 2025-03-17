using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Control : MonoBehaviour
{
  // Метод, который будет вызван при нажатии луча
  public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log("Луч нажат!");
        // Выполните необходимые действия
    }

    // Метод, который будет вызван при отпускании луча
    public void OnSelectExiting(SelectExitEventArgs args)
    {
        Debug.Log("Луч отпущен!");
        // Выполните необходимые действия
    }
}
