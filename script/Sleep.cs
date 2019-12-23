using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;


public class Sleep : MonoBehaviour
{
    //public GameObject objectToSpawn;
    public Animator animator;
    private AudioSource theAudio;

    [SerializeField] private AudioClip[] cilp;

    public void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }
    public void StartPlayback()
    {
        print("Activated");
        Invoke("Sleep_Audio", 3);
        Invoke("Sleep_Ani", 4); 
        

    }
    public void StopPlayback()
    {
        print("Deactivated");

        //animator.Play("Idle");
    }

    //오디오 실행 부분
    public void Sleep_Audio()
    {
        theAudio.mute = false;
        int i = 0;
        theAudio.clip = cilp[i];
        theAudio.Play();
    }
    //애니메이션 실행 부분
    public void Sleep_Ani()
    {
        animator.Play("sleep");
    }
}