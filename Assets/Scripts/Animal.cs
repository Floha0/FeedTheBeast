using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private PlayerController playerControllercs;
    private float rightBound = 17f;
    private float topBound = 15f;
    private float animalSpeed = 5f;

    void Start() {
        playerControllercs = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        // Moves animal
        transform.Translate(Vector3.forward * Time.deltaTime * animalSpeed);

        // Conrols if game over
        if (transform.position.z < -topBound){
            playerControllercs.health--;
            if (playerControllercs.health != 0){
                Debug.Log("Healt: " + playerControllercs.health);
            }else{
                Debug.Log("Game Over!");
            }
            Destroy(gameObject);
        }
        
        else if (transform.position.z > topBound){
            playerControllercs.health--;
            if (playerControllercs.health != 0){
                Debug.Log("Healt: " + playerControllercs.health);
            }else{
                Debug.Log("Game Over!");
            }
            Destroy(gameObject);
        }
        
        else if (transform.position.x > rightBound){
            playerControllercs.health--;
            if (playerControllercs.health != 0){
                Debug.Log("Healt: " + playerControllercs.health);
            }else{
                Debug.Log("Game Over!");
            }
            Destroy(gameObject);
        }
        
        else if (transform.position.x < -rightBound){
            playerControllercs.health--;
            if (playerControllercs.health != 0){
                Debug.Log("Healt: " + playerControllercs.health);
            }else{
                Debug.Log("Game Over!");
            }
            Destroy(gameObject);
        }
    }
}
