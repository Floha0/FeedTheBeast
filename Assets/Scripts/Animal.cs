using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private float downBound = -15f;
    private float animalSpeed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        // Moves animal
        transform.Translate(Vector3.forward * Time.deltaTime * animalSpeed);

        // Conrols if game over
        if (transform.position.z < downBound){
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
