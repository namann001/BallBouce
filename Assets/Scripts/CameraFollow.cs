using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target;
	private Vector3 target_Offset;
    public float iTime = 0.1f;
	public float zOffset = 15;
	
 private void Start()
 {
	 target_Offset = transform.position - target.position;
 }
 
 void Update()
 {
		
		if ((target.position.y > (transform.position.y + 2))) {
			transform.position = Vector3.Lerp(transform.position, target.position+target_Offset, iTime);
		}
		if (target.position.x != (transform.position.x)) {
			//Vector3 startPos = (0,0,0);
			Vector3 endPos = new Vector3(target.position.x + target_Offset.x, transform.position.y, transform.position.z);
			transform.position = Vector3.Lerp(transform.position, endPos, iTime);
		} 
		if (target.position.y < (transform.position.y - 10)) {
			FindObjectOfType<GameManager>().EndGame();
		}
 }
}
