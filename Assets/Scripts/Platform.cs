using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 15f; 
    //private float maxHeight = 10; 

    void OnCollisionEnter(Collision collision) {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        //Debug.Log("Y pos: " + rb.position.y);
        //Debug.Log("maxHeight: " + maxHeight);
        //Debug.Log("======================");
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