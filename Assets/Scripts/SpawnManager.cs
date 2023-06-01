using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int animalCount;
    public GameObject[] animalPrefabs;
    private float startTime = 0f;
    private float repeatTime = 4f;
    void Start()
    {
        // Spawn animals repeating every 4 seconds
        InvokeRepeating("spawnRandomAnimal", startTime, repeatTime);
    }

    void Update()
    {
    }

    void spawnRandomAnimal() {

        // Declare random animal and spawn bound variable 
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        float horizontalBound = Random.Range(-12.5f, 12.5f);

        // Spawn animal at location
        animalCount++;
        Instantiate(animalPrefabs[animalIndex], new Vector3(horizontalBound, 0.05f, 12f), animalPrefabs[animalIndex].transform.rotation);
        
    }
}