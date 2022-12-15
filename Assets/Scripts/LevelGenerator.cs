using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject platformMovePrefab;
    public GameObject platformMoveVerticalPrefab;
    public float numberOfPlatforms = 200f; 
    public float levelWidth = 3f;
    public float minY = 0.5f;
    public float maxY = 1.5f; 
    public float posX;
    public float previousPositionX;  
    private int temp; 
    
    //public Transform transform; 
    public void Spawn()
    {
        Vector3 spawnPosition = new Vector3();
        for(int i = 0; i<numberOfPlatforms; i++) {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            while ((Mathf.Abs(spawnPosition.x - previousPositionX) < 0.5) || (temp > 50) ) {
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                temp++;
            }
            temp = 0; 
            previousPositionX = spawnPosition.x;
            if (i > 35 && i % 2 == 0) {
                Instantiate(platformMovePrefab, spawnPosition, Quaternion.identity);
            }
            else if (i > 35 && i % 2 == 1) {
                Instantiate(platformMoveVerticalPrefab, spawnPosition, Quaternion.identity);
            }
            else if (i > 1 && i < 34 && i % 6 == 0) {
                Instantiate(platformMovePrefab, spawnPosition, Quaternion.identity);
            }
            else if (i > 1 && i < 34 && i % 9 == 0) {
                Instantiate(platformMoveVerticalPrefab, spawnPosition, Quaternion.identity);
            }
            else {
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
