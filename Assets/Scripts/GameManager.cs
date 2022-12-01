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
    //public Animator anim = GetComponent<Animator>(); 

    void Update() {
        if (Input.GetKeyUp(KeyCode.Space) && newGame) {
            StartGame();
            //anim.Play("BallBounceStartGame");
            newGame = false; 
        }
    }
    
    public void StartGame() {
        FindObjectOfType<LevelGenerator>().Spawn();
    }
    
    public void EndGame() {
    if (gameHasEnded == false) {
        gameHasEnded = true; 
        Debug.Log("Game Over");
        //Invoke("Restart", restartDelay);
        Restart();
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        newGame = true; 
    }
    
    
}
}
