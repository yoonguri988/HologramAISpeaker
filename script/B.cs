using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class B : MonoBehaviour
{
    public Animator animator;
    private AudioSource theAudio;

    [SerializeField] private AudioClip[] cilp;

    public void StartPlayback()
    {
        animator.Play("B");

    }
    public void StopPlayback()
    {
        print("Deactivated");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
