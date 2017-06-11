using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csTrigger : MonoBehaviour {

    public AudioClip Clip1;
    public AudioClip Clip2;
    public AudioClip Clip3;
    public AudioClip Clip4;
    public float vol = 1.0f;

    public int hit_Count = 0;

    Vector3 Velocity = new Vector3(500.0f, 500.0f, 500.0f);

    csCharacterMove2 script;
    GameObject obj = null;

    GameObject[] UpCube = new GameObject[6];
    GameObject[] DownCube = new GameObject[6];
    GameObject[] UpDownCube = new GameObject[6];

    void Start()
    {
        //Clip = GetComponent<AudioSource>();
        obj = GameObject.Find("Dog");
        script  = obj.GetComponent<csCharacterMove2>();

        UpCube[0] = GameObject.Find("UpCube1");
        UpCube[1] = GameObject.Find("UpCube2");
        UpCube[2] = GameObject.Find("UpCube3");
        UpCube[3] = GameObject.Find("UpCube4");
        UpCube[4] = GameObject.Find("UpCube5");
        UpCube[5] = GameObject.Find("UpCube6");

        DownCube[0] = GameObject.Find("DownCube1");
        DownCube[1] = GameObject.Find("DownCube2");
        DownCube[2] = GameObject.Find("DownCube3");
        DownCube[3] = GameObject.Find("DownCube4");
        DownCube[4] = GameObject.Find("DownCube5");
        DownCube[5] = GameObject.Find("DownCube6");

        UpDownCube[0] = GameObject.Find("UpCube7");
        UpDownCube[1] = GameObject.Find("DownCube7");
        UpDownCube[2] = GameObject.Find("UpCube8");
        UpDownCube[3] = GameObject.Find("DownCube8");
        UpDownCube[4] = GameObject.Find("UpCube9");
        UpDownCube[5] = GameObject.Find("DownCube9");


        // hit_Count = 0;

    }

    void OnTriggerEnter(Collider other)
    {
        hit_Count++;

        switch(hit_Count)
        {
            case 1:
                //GetComponent<AudioSource>().PlayOneShot(Clip1, vol);

                //TEST
                ///////////////////////////////////////////
                GetComponent<AudioSource>().PlayOneShot(Clip2, vol);
                script.Set_Position();
                script.Way3_MoveOn();
                //////////////////////////////////////////
                break;
            case 2:
                script.ZigZag_MoveOn();
                break;
            case 3:
                //UpCube[0].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                //UpCube[1].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                //TEST
                /////////////////////////////////
                Debug.Log("점프대 오픈!");
                // Velocity = Velocity * Time.deltaTime;
                Velocity = new Vector3(500.0f, 500.0f, 500.0f);
                GetComponent<Rigidbody>().AddForce(Velocity);
               // obj.GetComponent<Rigidbody>().AddForce(45.0f, 45.0f, 0.0f);
                ////////////////////////////////
                break;
            case 4:
                //////////////////////////////////////////////////////////
                Debug.Log("점프대222222");
                // Velocity = Velocity * Time.deltaTime;
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Velocity = new Vector3(-500.0f,500.0f, 500.0f);
                GetComponent<Rigidbody>().AddForce(Velocity);
                /////////////////////////////////////////////////////////

                //UpCube[2].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                //UpCube[3].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                break;
            case 5:

                ///////////////////////////////////////
                Debug.Log("점프대3333333");
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Velocity = new Vector3(500.0f, 400.0f, 500.0f);
                GetComponent<Rigidbody>().AddForce(Velocity);
                ////////////////////////////////////////

                //UpCube[4].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                //UpCube[5].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                break;
            case 6:
                ////////////////////////////////////////
                Debug.Log("점프대라스트");
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Velocity = new Vector3(0.0f, 400.0f, 500.0f);
                GetComponent<Rigidbody>().AddForce(Velocity);

                ////////////////////////////////////////
                DownCube[0].transform.Translate(new Vector3(0.0f, -2.5f, 0.0f));
                DownCube[1].transform.Translate(new Vector3(0.0f, -2.5f, 0.0f));
                break;
            case 7:
                DownCube[2].transform.Translate(new Vector3(0.0f, -2.5f, 0.0f));
                DownCube[3].transform.Translate(new Vector3(0.0f, -2.5f, 0.0f));
                break;
            case 8:
                DownCube[4].transform.Translate(new Vector3(0.0f, -2.5f, 0.0f));
                DownCube[5].transform.Translate(new Vector3(0.0f, -2.5f, 0.0f));
                break;
            case 9:
                UpDownCube[0].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                UpDownCube[1].transform.Translate(new Vector3(0.0f, -2.5f, 0.0f));
                break;
            case 10:
                UpDownCube[2].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                UpDownCube[3].transform.Translate(new Vector3(0.0f, -2.5f, 0.0f));
                break;
            case 11:
                UpDownCube[4].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                UpDownCube[5].transform.Translate(new Vector3(0.0f, -2.5f, 0.0f));
                break;
            case 12:
                script.Way2_MoveOn();
                break;
            case 13:
                GetComponent<AudioSource>().Stop();
                break;
            case 14:
                GetComponent<AudioSource>().PlayOneShot(Clip2, vol);
                script.Set_Position();
                script.Way3_MoveOn();
                break;
            case 15:
                script.Way3_MoveOn();
                break;
            case 16:
                obj.GetComponent<Rigidbody>().AddForce(45.0f, 45.0f, 0.0f);
                break;
            default:
                break;
        }
    }
}
