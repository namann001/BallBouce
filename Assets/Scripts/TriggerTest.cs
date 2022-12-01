using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
{
    Debug.Log(" You entered the triggerarea.");
}
    private void OnTriggerStay(Collider other)
{
    Debug.Log(" You are in the triggerarea.");
}    
private void OnTriggerExit(Collider other)
{
    Debug.Log(" You left the triggerarea.");
}
}
