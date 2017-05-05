using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csActive : MonoBehaviour {

    public GameObject obj;

    public void SetActive()
    {
        obj.SetActive(!obj.activeSelf);
    }
}
