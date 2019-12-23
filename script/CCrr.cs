using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;


public class CCrr : MonoBehaviour
{
    public Transform cat;
    bool canFire;
    public float fAniTime = 0.3f;  // 0.3초 마다 
    float fTimeCalc = 0;
    int cnt = 0;
    public void StartPlayback()
    {
        if (cnt == 0)
        {
            Instantiate(cat, transform.position, Quaternion.identity);
            cnt = 1;
        }
    }

        // Use this for initialization
        public void StopPlayback()
    {

    }

}
  

