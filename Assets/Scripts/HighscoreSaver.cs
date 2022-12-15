using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreSaver : MonoBehaviour
{
    public Text ScoreSaver;

    public void displayScore(int score){
        ScoreSaver.text = "Highscore: " + score.ToString();
    }

    public void hideScore() {
        ScoreSaver.text = ""; 
    }
}
