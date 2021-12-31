using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleController : MonoBehaviour
{
    public GameObject obj;

    /// <summary>
    /// Toggle object on or off
    /// </summary>
    public void changeStatus()
    {
        if (obj.activeInHierarchy)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    }
}