using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima : MonoBehaviour
{
    public Animator animator; // —сылка на компонент Animator
    public string animationName = "nanes"; // »м€ анимации, которую нужно запустить

    public void PlayAnim()
    {
        animator.Play(animationName);
    }
}
