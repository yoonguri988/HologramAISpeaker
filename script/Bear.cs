using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bear : MonoBehaviour
{
    public Animator animator;
    public Transform BEAR;
    public Transform MONKEY;
    bool canFire;
    int cnt = 0;
    public float fAniTime = 0.3f;  // 0.3초 마다 
    float fTimeCalc = 0;
    // Start is called before the first frame update
    public void StartPlayback()
    {
        if (cnt == 0)
        {
            Instantiate(BEAR, transform.position, Quaternion.identity);
            // Instantiate(MONKEY, transform.position, Quaternion.identity);
            cnt = 1;
        }
        //for (int i = 0; i < 10; i++)
        // Instantiate(cat, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
    }

    // Use this for initialization
    public void StopPlayback()
    {
        //animator.Play("Jump");
        //Instantiate(MONKEY, transform.position, Quaternion.identity);
    }
}
