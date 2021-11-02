using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAndHide : MonoBehaviour
{
    public GameObject Object;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            Object.SetActive(false);
        if (Input.GetKeyDown(KeyCode.S))
            Object.SetActive(true);
    }        
}
      
