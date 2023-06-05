using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private PlayerController playerControllercs;
    void Start()
    {
        playerControllercs = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        
    }

    // Detects if projectile enters collider
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Projectile")){
            playerControllercs.health++;
            Debug.Log("Healt: " + playerControllercs.health);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
