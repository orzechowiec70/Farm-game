using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 18.3f;
    private float spawnPosZ = 20.0f;
    private float timeDelay = 2;
    private float spawnInterval = 4;
    private int startingPointLeftRight = 26;
    
    // Spawning animals after 2 seconds in the interval of 2 seconds
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalForward", timeDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", timeDelay+1, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", timeDelay+2, spawnInterval);
    }

    void Update()
    {
        
    }

    // Spawning random animals and giving them spawning range and Z position
    void SpawnRandomAnimalForward()
    {
        int animalIndexForward = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPositionX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndexForward], spawnPositionX, animalPrefabs[animalIndexForward].transform.rotation);
    }
    
    void SpawnRandomAnimalLeft()
    {
        int animalIndexLeft = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPositionLeft = new Vector3(-startingPointLeftRight, 0, Random.Range(1.0f, 17.0f));
        Quaternion rotationLeft = Quaternion.Euler(0, 270, 0);
        Instantiate(animalPrefabs[animalIndexLeft], spawnPositionLeft, animalPrefabs[animalIndexLeft].transform.rotation * rotationLeft);
    }

    void SpawnRandomAnimalRight()
    {
        int animalIndexRight = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPositionRight = new Vector3(startingPointLeftRight, 0, Random.Range(1.0f, 17.0f));
        Quaternion rotationRight = Quaternion.Euler(0, 90, 0);
        Instantiate(animalPrefabs[animalIndexRight], spawnPositionRight, animalPrefabs[animalIndexRight].transform.rotation * rotationRight);
    }
}
