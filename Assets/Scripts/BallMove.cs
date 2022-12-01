using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

private float movement = 0f;
public float speed = 3f; 

Rigidbody rb; 

void Start(){
    rb = GetComponent<Rigidbody>();
}

void Update() {
    movement = Input.GetAxis("Horizontal") * speed;
}

void FixedUpdate() {
    Vector3 velocity = rb.velocity;
    velocity.x = movement;
    rb.velocity = velocity;  
}
}
