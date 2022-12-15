using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
//using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; 
    bool newGame = true; 
    public float restartDelay = 2f; 
    public Transform target; 
    private int gameScore = 0; 
    public int highScore = 0;
    //public Text HighScoreSaver; 
    
    void Start() {
        highScore = PlayerPrefs.GetInt("SavedScoreKey", 0);
        FindObjectOfType<HighscoreSaver>().displayScore(highScore);
    }

    void Update() {
        if (Input.GetKeyUp(KeyCode.Space) && newGame) {
            StartGame();
            newGame = false; 
        }
    }
    
    public void StartGame() {
        FindObjectOfType<LevelGenerator>().Spawn();
        FindObjectOfType<HighscoreSaver>().hideScore();
        //FindObjectOfType<BackgroundMusic>().PlaySound();
    }
    
    public void EndGame() {
    if (gameHasEnded == false) {
        gameHasEnded = true; 
    }
        Debug.Log("Game Over");
        FindObjectOfType<BackgroundMusic>().StopSound();
        gameScore = FindObjectOfType<Score>().getScore();
        if (gameScore > highScore) {
            PlayerPrefs.SetInt("SavedScoreKey", gameScore);
            PlayerPrefs.Save();
        }
       
        Restart();
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        newGame = true; 
        //FindObjectOfType<BackgroundMusic>().PlaySound();
        FindObjectOfType<HighscoreSaver>().displayScore(highScore);

    }
    
    
}

