using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] projectilePrefab;
    [SerializeField] private float xRange = 14f;
    private float moveHorizontal;
    private float speed = 12f;

    void Start()
    {
        
    }

    
    void Update()
    {
        // Player movement
        moveHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * moveHorizontal);

        // Limit player position x
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        spawnRandomAnimal();
    }
    
    void spawnRandomAnimal(){
        // Spawn projectile
        if (Input.GetKeyDown(KeyCode.Space)){
            int projectileIndex = Random.Range(0,projectilePrefab.Length);
            Instantiate(projectilePrefab[projectileIndex], transform.position, projectilePrefab[projectileIndex].transform.rotation);
        }
    }
}
