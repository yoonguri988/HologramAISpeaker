using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    public void StartPlayback()
    {
        animator.Play("Dance");
    }
    public void StopPlayback()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
