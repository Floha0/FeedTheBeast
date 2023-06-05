using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
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
        Vector3 randomLocation = new Vector3(0,0,0);
        Quaternion randomRotation = Quaternion.Euler(0,0,0);
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        float horizontalBound = Random.Range(-12.5f, 12.5f);
        float verticalBound = Random.Range(-7f, 7f);

        // Spawn animal at location
        switch(Random.Range(0,4)) 
        {
            case 0:
                randomLocation = new Vector3(horizontalBound, 0.05f, 12f);
                randomRotation = Quaternion.Euler(0,180,0);
                break;
            case 1:
                randomLocation = new Vector3(horizontalBound, 0.05f, -12f);
                randomRotation = Quaternion.Euler(0,0,0);
                break;
            case 2:
                randomLocation = new Vector3(16, 0.05f, verticalBound);
                randomRotation = Quaternion.Euler(0,-90,0);
                break;
            case 3:
                randomLocation = new Vector3(-16, 0.05f, verticalBound);
                randomRotation = Quaternion.Euler(0,90,0);
                break;
        }

        Instantiate(animalPrefabs[animalIndex], randomLocation, randomRotation);
    }
}
