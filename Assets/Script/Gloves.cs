using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Gloves : MonoBehaviour
{

    public ActionBasedController leftController, rightController;
    public GameObject leftGlove, rightGlove;
    
    public void ChangeGloveLeft()
    {
        leftController.modelPrefab = leftGlove.transform;
    }
    public void ChangeGloveRight()
    {
        rightController.modelPrefab = rightGlove.transform;
    }
    
  // Метод, который будет вызван при нажатии луча
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        ChangeGloveRight();
        ChangeGloveLeft();
    }
}
