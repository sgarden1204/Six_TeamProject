using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCanvas : MonoBehaviour {

    public Canvas canvas;
    bool active;
    //GameObject obj;

    void Start()
    {
       // obj = GameObject.FindGameObjectWithTag("Setting");
        active = false;
    }

    public void Canvas()
    {
        active = !active;

        if (active)
        {
            //obj.SetActive(true);
            canvas.sortingOrder = 2;
        }
        else
        {
            //obj.SetActive(false);
            canvas.sortingOrder = 0;
        }
    }

}
