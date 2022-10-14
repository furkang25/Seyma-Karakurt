using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float paddleSpeed = 0.5f;

    private Vector3 playerPos = new Vector3 (0, -9.5f, 0);

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3 (Mathf.Clamp (xPos, -7f, 7f), -9.5f, 0f);
        transform.position = playerPos;
        
    }
}
