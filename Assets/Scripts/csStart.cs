using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class csStart : MonoBehaviour {

    public void Next()
    {
        SceneManager.LoadScene("Main_Game_Scene");
        //Application.LoadLevel("Main_Game_Scene");
    }
}
