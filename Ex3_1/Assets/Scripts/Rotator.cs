using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    float speed = 50f;
    [Tooltip("V to move left, No V to move right")][SerializeField]
    bool ClockWise = true;
    
    void Update()
    {
        if (ClockWise)
            transform.Rotate(new Vector3(0f, 0f, speed) * Time.deltaTime);
        if(!ClockWise)
            transform.Rotate(new Vector3(0f, 0f, -speed) * Time.deltaTime);
    }
}
