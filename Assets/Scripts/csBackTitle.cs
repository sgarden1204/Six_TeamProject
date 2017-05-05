using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class csBackTitle : MonoBehaviour {

    public void Back_Title()
    {
        SceneManager.LoadScene("Title_Scene");
        //Application.LoadLevel("Title_Scene");
    }
}
