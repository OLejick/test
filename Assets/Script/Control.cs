using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Control : MonoBehaviour
{
  // �����, ������� ����� ������ ��� ������� ����
  public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log("��� �����!");
        // ��������� ����������� ��������
    }

    // �����, ������� ����� ������ ��� ���������� ����
    public void OnSelectExiting(SelectExitEventArgs args)
    {
        Debug.Log("��� �������!");
        // ��������� ����������� ��������
    }
}
