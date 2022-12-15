using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

private float movement = 0f;
public float speed = 5f; 

Rigidbody rb; 
public Transform transform;

void Start(){
    rb = GetComponent<Rigidbody>();
}

void Update() {
    movement = Input.GetAxis("Horizontal") * speed;
    if (Input.GetKey(KeyCode.LeftArrow)  || Input.GetKey(KeyCode.A))
{
    // Rotate the ball left
    transform.Rotate(Vector3.forward * 4, Space.Self);
}
if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
{
    // Rotate the ball right
    transform.Rotate(Vector3.back * 4, Space.Self);
}
}

void FixedUpdate() {
    Vector3 velocity = rb.velocity;
    velocity.x = movement;
    rb.velocity = velocity;  
}
}
