using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csTrigger : MonoBehaviour {

    public AudioClip Clip;
    public float vol = 1.0f;

    private int hit_Count;

    GameObject obj = null;

    void Start()
    {
        //Clip = GetComponent<AudioSource>();
        hit_Count = 0;
        obj = GameObject.Find("Dog");
    }

    void OnTriggerEnter(Collider other)
    {
        hit_Count++;

        switch(hit_Count)
        {
            case 1:
            GetComponent<AudioSource>().PlayOneShot(Clip, vol);
                break;
            case 2:
                csCharacterMove2 script = obj.GetComponent<csCharacterMove2>();
                script.ZigZag_MoveOn();
                break;

            default:
                break;
        }
    }
}
