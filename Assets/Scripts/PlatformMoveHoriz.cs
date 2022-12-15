using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveHoriz : MonoBehaviour
{
    public float jumpForce = 21f; 

    public float speed = 1; //Public float to control platform speed
    public float moveDistance = 3; //Public float to control distance of movement

    private Vector3 originPosition; //Position of the platform when the application starts
    public new Transform transform; 

    void Start()
    {
        originPosition = transform.position; //Saves the platform's starting position
    }

    void Update()
    {
        //Moves the platform up and down
        transform.position = new Vector3(originPosition.x + Mathf.Sin(Time.time * speed) * moveDistance, originPosition.y, originPosition.z);
    }

    void OnCollisionEnter(Collision collision) {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
         if (collision.transform.position.y <= rb.position.y) {
            if (rb != null) {
            FindObjectOfType<BounceAudio>().PlaySound();
            Vector3 velocity = rb.velocity; 
            velocity.y = jumpForce;
            rb.velocity = velocity;
            }
        }
    }
}
