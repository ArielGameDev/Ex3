using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Mover : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = new Vector2
            (Mathf.Clamp(pos.x, -12f, 12f),
            Mathf.Clamp(pos.y, -5.75f, 5.75f));
    }
}
