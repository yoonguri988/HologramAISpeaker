using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Leap;


public class Move : MonoBehaviour
{
    public Animator animator;
    Vector3 target = new Vector3(0.16f, -2, -5);
    public int cnt = 0;
    private AudioSource theAudio;
    [SerializeField] private AudioClip full;
    [SerializeField] private AudioClip hungry;
    // Start is called before the first frame update
    public void StartPlayback()
    {
        print("Activated");

        if (cnt == 0)
        {
            theAudio.mute = false;
            theAudio.clip = hungry;
            theAudio.Play();
        }
        if (cnt < 5)
        {

            animator.Play("cute");
            cnt++;
        }
        else if (cnt >= 5)
        {
            theAudio.mute = false;
            theAudio.clip = full;
            animator.Play("Yelling");
            theAudio.Play();

            if (DateTime.Now.ToString("HH:mm") == "20:00" || DateTime.Now.ToString("HH:mm") == "14:00" || DateTime.Now.ToString("HH:mm") == "7:00")
            {
                cnt = 0;
            }
        }

    }
    public void StopPlayback()
    {
        print("dd");

    }
    public void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }
}
