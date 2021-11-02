using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    
    float time = 0f;
    float speed = 1f;
    int phase = 0;
    void Update()
    {
        time += Time.fixedDeltaTime;
        if (time > 1f)
        {
            phase++;
            phase %= 4;
            time = 0f;
        }
        switch (phase)
        {
            case 0:
                transform.Rotate(0f, 0f, speed * (1 - time));
                break;
            case 1:
                transform.Rotate(0f, 0f, -speed * time);
                break;
            case 2:
                transform.Rotate(0f, 0f, -speed * (1 - time));
                break;
            case 3:
                transform.Rotate(0f, 0f, speed * time);
                break;

        }
    }
}
