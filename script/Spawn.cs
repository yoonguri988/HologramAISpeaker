using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Animator animator;
  
    public void StartPlayback()
    {
        print("Activated");

        animator.Play("Eat");

    }
    public void StopPlayback()
    {
        print("Deactivated");

        animator.Play("Idle");
    }
}

