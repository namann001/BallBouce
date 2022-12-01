using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform target; 
    public Text scoreText;
    private int currentScore = 0;
     

 public void Update()
    {
        if (target.transform.position.y > currentScore) {
            currentScore = (int)(target.transform.position.y) - 5;
        }
	    scoreText.text = currentScore.ToString();
    }
}