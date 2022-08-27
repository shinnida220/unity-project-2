using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Holds the list of animal prefabs
    public GameObject[] animalPrefabs;

    // SpawnPosition of animalPrefabs
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // delay before the first invoke of animal spawning
    private float startDelay = 2;

    // Interval between invocation afterwards
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Use to call method repeatedly
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.S))
        // {
        //     SpawnRandomAnimal();
        // }
    }

    
    void SpawnRandomAnimal()
    {
        // Generate a random number within the range of animals we have
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        // Spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
        // Generate the random animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
