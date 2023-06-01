using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // Detects if projectile enters collider
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
