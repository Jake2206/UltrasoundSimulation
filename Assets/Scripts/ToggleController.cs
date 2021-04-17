using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleController : MonoBehaviour
{
    public GameObject obj;
    public bool isactive;
    public void changeStatus()
    {
        if(isactive == true)
        {
            isactive = false;
            obj.SetActive(isactive);
        }
        else
        {
            isactive = true;
            obj.SetActive(isactive);
        }
    }
}
