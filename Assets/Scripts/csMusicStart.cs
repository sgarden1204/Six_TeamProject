using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMusicStart : MonoBehaviour {

    public AudioClip Clip;
    public float vol = 1.0f;

    //void Start()
    //{
    //    Clip = GetComponent<AudioSource>();
    //}

    void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().PlayOneShot(Clip, vol);
    }
}
