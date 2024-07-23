using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public GameObject[] enemiesPrefabs;
    public GameObject[] powerupsPrefabs;
    private float xPositionSpawn = 3.5f;

    //Spawn timing
    private float startEnemieDelay = 2.0f;
    private float startPowerupDelay = 5.0f;
    private float spawnEnemieInterval = 1.5f;
    private float spawnPowerupInterval = 3.5f;



    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemie", startEnemieDelay, spawnEnemieInterval);

        InvokeRepeating("SpawnRandomPowerup", startPowerupDelay, spawnPowerupInterval);
    }

    void SpawnRandomEnemie() 
    {
        int enemie = Random.Range(0, enemiesPrefabs.Length);
        float randomPosition = Random.Range(-xPositionSpawn,xPositionSpawn);
        Vector3 spawnPosition = new Vector3(randomPosition,0.238f,5.35f);
        Instantiate(enemiesPrefabs[enemie], spawnPosition, enemiesPrefabs[enemie].transform.rotation);
    }

    void SpawnRandomPowerup()
    {
        int powerupIndex = Random.Range(0, powerupsPrefabs.Length);
        float randomPosition = Random.Range(-xPositionSpawn, xPositionSpawn);
        Vector3 spawnPosition = new Vector3(randomPosition, 0.238f, 5.35f);
        Instantiate(powerupsPrefabs[powerupIndex], spawnPosition, powerupsPrefabs[powerupIndex].transform.rotation);
    }
}
