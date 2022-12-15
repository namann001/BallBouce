using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreCounter : MonoBehaviour
{
    [SerializeField] private Text text;
    private int currentHighscore = 0;

 public void setHighscore()
    {
	currentHighscore += 10;

	text.text = currentHighscore.ToString();
    }

    public int getScore() {
        return currentHighscore; 
    }
}
