using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyScript : MonoBehaviour {
    public float SpawnRate = 1;
    float NextSpawn = 0;
    public Transform spawnPoint;
    public GameObject enemy;
    void Start(){
        
    }

    void Update(){
        if (Time.time > NextSpawn){
            NextSpawn = Time.time + SpawnRate;
            spawn();
        }
    }
    void spawn(){
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
