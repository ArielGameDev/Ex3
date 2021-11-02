using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{

    [SerializeField]
    public GameObject player;
    [SerializeField]
    public float speed;
    [SerializeField]
    public Vector2 position;
    [SerializeField]
    public float topLimit;
    [SerializeField]
    public float buttomLimit;
    [SerializeField]
    public float rightLimit;
    [SerializeField]
    public float leftLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPosition = transform.position;
        Vector3 endPoistion = player.transform.position;

        endPoistion.x += position.x;
        endPoistion.y += position.y;
        //transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        transform.position = Vector3.Lerp(startPosition, endPoistion, speed * Time.deltaTime);

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, buttomLimit, topLimit), -10
            );
    }
}
