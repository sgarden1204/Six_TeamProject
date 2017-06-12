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
    GameObject[] ChangeSphere = new GameObject[10];
    GameObject[] MoveBlock = new GameObject[5];
    GameObject[] FinalStage = new GameObject[5];

    public Material Type1;

    void Start()
    {
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

        ChangeSphere[0] = GameObject.Find("Sphere1");
        ChangeSphere[1] = GameObject.Find("Sphere2");
        ChangeSphere[2] = GameObject.Find("Sphere3");
        ChangeSphere[3] = GameObject.Find("Sphere4");
        ChangeSphere[4] = GameObject.Find("Sphere42");
        ChangeSphere[5] = GameObject.Find("Sphere5");
        ChangeSphere[6] = GameObject.Find("Sphere52");
        ChangeSphere[7] = GameObject.Find("Sphere6");
        ChangeSphere[8] = GameObject.Find("Sphere62");

        MoveBlock[0] = GameObject.Find("BlockMove1");
        MoveBlock[1] = GameObject.Find("BlockMove2");
        MoveBlock[2] = GameObject.Find("BlockMove3");
        MoveBlock[3] = GameObject.Find("BlockMove4");
        MoveBlock[4] = GameObject.Find("BlockMove5");

        FinalStage[0] = GameObject.Find("Goal1");
        FinalStage[1] = GameObject.Find("Goal2");
        FinalStage[2] = GameObject.Find("Goal3");
        FinalStage[3] = GameObject.Find("Goal4");
        FinalStage[4] = GameObject.Find("Goal5");
    }

    void Update()
    {
        if(this.transform.position.y < -10.0f)
        {
            hit_Count = 0;
            this.transform.localRotation = Quaternion.identity;
            this.transform.position = new Vector3(0.0f, 1.0f, 0.0f);
            script.Re_Start();
            GetComponent<AudioSource>().Stop();
        }
    }


    void OnTriggerEnter(Collider other)
    {
        hit_Count++;

        //switch(hit_Count)
        //{
        //    case 1:
        //        script.Set_Position2();
        //        script.Way3_MoveOn();
        //        break;
        //    case 2:
        //        GetComponent<AudioSource>().PlayOneShot(Clip3, vol);
        //        break;

        //    case 3:
        //        ChangeSphere[0].GetComponent<Renderer>().material.color = Color.green;
        //        Debug.Log("첫번째 원");
        //        break;
        //    case 4:
        //        ChangeSphere[1].GetComponent<Renderer>().material.color = Color.green;
        //        Debug.Log("2222번째 원");
        //        break;
        //    case 5:
        //        ChangeSphere[2].GetComponent<Renderer>().material.color = Color.green;
        //        Debug.Log("3333번째 원");
        //        break;
        //    case 6:
        //        ChangeSphere[3].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
        //        ChangeSphere[4].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
        //        break;
        //    case 7:
        //        ChangeSphere[5].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
        //        ChangeSphere[6].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
        //        break;
        //    case 8:
        //        ChangeSphere[7].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
        //        ChangeSphere[8].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
        //        break;
        //    case 9:
        //        script.ZigZag_MoveOn();
        //        break;
        //    case 10:
        //        MoveBlock[0].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
        //        break;
        //    case 11:
        //        MoveBlock[1].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
        //        break;
        //    case 12:
        //        MoveBlock[2].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
        //        break;
        //    case 13:
        //        MoveBlock[3].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
        //        break;
        //    case 14:
        //        MoveBlock[4].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
        //        break;
        //    case 15:
        //        FinalStage[0].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
        //        break;
        //    case 16:
        //        FinalStage[1].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
        //        break;
        //    case 17:
        //        FinalStage[2].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
        //        break;
        //    case 18:
        //        FinalStage[3].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
        //        break;
        //    case 19:
        //        FinalStage[4].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
        //        break;
        //    default:
        //        break;
        //}

        switch (hit_Count)
        {
            case 1:
                GetComponent<AudioSource>().PlayOneShot(Clip1, vol);
                break;
            case 2:
                script.ZigZag_MoveOn();
                break;
            case 3:
                UpCube[0].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                UpCube[1].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                //TEST
                /////////////////////////////////
                ////////////////////////////////
                break;
            case 4:
                //////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////

                UpCube[2].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                UpCube[3].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                break;
            case 5:

                ///////////////////////////////////////
                ////////////////////////////////////////

                UpCube[4].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                UpCube[5].transform.Translate(new Vector3(0.0f, 3.0f, 0.0f));
                break;
            case 6:
                ////////////////////////////////////////

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
                script.ZigZag_MoveOn();
                break;
            case 16:
                Velocity = new Vector3(500.0f, 500.0f, 500.0f);
                GetComponent<Rigidbody>().AddForce(Velocity);
                break;

            case 17:
                // Velocity = Velocity * Time.deltaTime;
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Velocity = new Vector3(-500.0f, 500.0f, 500.0f);
                GetComponent<Rigidbody>().AddForce(Velocity);
                break;

            case 18:
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Velocity = new Vector3(500.0f, 400.0f, 500.0f);
                GetComponent<Rigidbody>().AddForce(Velocity);
                break;

            case 19:
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                Velocity = new Vector3(0.0f, 400.0f, 300.0f);
                GetComponent<Rigidbody>().AddForce(Velocity);
                break;

            case 20:
                script.ZigZag_MoveOn();
                break;
            case 21:
                this.transform.localRotation = Quaternion.identity;
                this.transform.position = new Vector3(19.82f, 1.0f, 1480.0f);
                GetComponent<AudioSource>().Stop();
                GetComponent<AudioSource>().PlayOneShot(Clip3, vol);
                break;

            case 22:
                //script.Set_Position();
                script.Way3_MoveOn();
                ChangeSphere[0].GetComponent<Renderer>().material.color = Color.green;
                break;

            case 23:
                //GetComponent<AudioSource>().PlayOneShot(Clip3, vol);
                ChangeSphere[1].GetComponent<Renderer>().material.color = Color.green;
                break;

            case 24:
                ChangeSphere[2].GetComponent<Renderer>().material.color = Color.green;
                break;
            case 25:
                ChangeSphere[3].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                ChangeSphere[4].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
                break;
            case 26:
                ChangeSphere[5].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
                ChangeSphere[6].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                break;
            case 27:
                ChangeSphere[7].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
                ChangeSphere[8].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                break;
            case 28:
                script.ZigZag_MoveOn();
                break;
            case 29:
                MoveBlock[0].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                break;
            case 30:
                MoveBlock[1].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
                break;
            case 31:
                MoveBlock[2].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                break;
            case 32:
                MoveBlock[3].transform.Translate(new Vector3(+5.0f, 0.0f, 0.0f));
                break;
            case 33:
                MoveBlock[4].transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                break;
            case 34:
                FinalStage[0].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
                break;
            case 35:
                FinalStage[1].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
                break;
            case 36:
                FinalStage[2].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
                break;
            case 37:
                FinalStage[3].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
                break;
            case 38:
                FinalStage[4].transform.Translate(new Vector3(0.0f, +45.0f, 0.0f));
                break;
            case 39:
                break;
            case 40:
                break;
            default:
                break;
        }


    }
}
