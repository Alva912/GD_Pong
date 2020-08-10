using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Vertical";

    void FixedUpdate(){

        float v = Input.GetAxisRaw(axis);
        // We use GetAxisRaw to check the vertical input axis. 
        // This will return 1 when pressing either the W key, the UpArrow key, or when pointing a gamepad's stick upwards. 
        // It will return -1 when using the S key, the DownArrow key, or when pointing a gamepad's stick downwards. 
        // It will return 0 when none of those keys are pressed.

        GetComponent<Rigidbody2D>().velocity = new Vector2(0,v) * speed;
        // Rigidbody's velocity = movement direction * speed


    }
}
