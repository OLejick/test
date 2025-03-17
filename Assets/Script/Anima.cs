using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima : MonoBehaviour
{
    public Animator animator; // ������ �� ��������� Animator
    public string animationName = "nanes"; // ��� ��������, ������� ����� ���������

    public void PlayAnim()
    {
        animator.Play(animationName);
    }
}
