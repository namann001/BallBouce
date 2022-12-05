using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; 
    bool newGame = true; 
    public float restartDelay = 2f; 
    public Transform target; 

    void Update() {
        if (Input.GetKeyUp(KeyCode.Space) && newGame) {
            StartGame();
            newGame = false; 
        }
    }
    
    public void StartGame() {
        FindObjectOfType<LevelGenerator>().Spawn();
        //FindObjectOfType<BackgroundMusic>().PlaySound();
    }
    
    public void EndGame() {
    if (gameHasEnded == false) {
        gameHasEnded = true; 
        Debug.Log("Game Over");
        FindObjectOfType<BackgroundMusic>().StopSound();
        Restart();
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        newGame = true; 
        //FindObjectOfType<BackgroundMusic>().PlaySound();
    }
    
    
}
}
