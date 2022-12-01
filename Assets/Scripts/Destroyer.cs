using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject player;
    //public GameObject platform;
    
    void OnTriggerEnter(Collider collision) {
        Destroy(collision.gameObject);
    }
}
