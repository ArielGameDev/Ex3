using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Mover : MonoBehaviour
{
    [SerializeField]
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        // Player moves with arrows
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }

        // Update player position
        transform.position = new Vector2
            (Mathf.Clamp(pos.x, -12f, 12f),
            Mathf.Clamp(pos.y, -6f, 6f));
    }
}
