using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
public class Hand : MonoBehaviour
{
    public Animator animator;
    private AudioSource theAudio;
    [SerializeField] private AudioClip[] cilp;
    // Start is called before the first frame update
    public void StartPlayback()
    {
        animator.Play("hand");

    }
    public void StopPlayback()
    {
        print("Deactivated");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
