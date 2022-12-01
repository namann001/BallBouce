using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour
{
 private float horizontal;
 private float vertical;
 private Vector3 direction;
 
 public float speed = 5.0f;
 public float m_Thrust = 20f;
 public Rigidbody m_Rigidbody; 

 //public Animator anim; 

 void Update(){
 	horizontal = Input.GetAxis("Horizontal");
 	vertical = Input.GetAxis("Vertical");
 	direction = new Vector3(horizontal, 0, vertical);
 	
	 transform.Translate(direction * speed * Time.deltaTime);

/*      if (direction != Vector3.zero) {
        anim.SetFloat("speed", 1.0f);
     }
     else {
        anim.SetFloat("speed", 0f);
     } */

     //anim.SetFloat("speed", Input.GetAxis("Vertical"));
     //anim.SetFloat("speed", Input.GetAxis("Horizontal"));

     if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }
 }

/*   void OnCollisionEnter(Collision collision)
    {
         Debug.Log(" You collided.");
    }
void OnCollisionStay(Collision collision)
    {
         Debug.Log(" You are colliding.");
    }
void OnCollisionExit(Collision collision)
    {
         Debug.Log(" You stopped colliding.");
    } */ 
}
