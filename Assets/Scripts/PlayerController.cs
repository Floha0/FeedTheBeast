using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health;
    public GameObject[] projectilePrefab;
    [SerializeField] private float xRange = 14f;
    [SerializeField] private float zRange = 7f;
    private float moveHorizontal;
    private float speed = 8f;
    private float rotationSpeed = 150f;
    private float moveVertical;
    

    void Update(){
        spawnProjectile();
    }

    void FixedUpdate()
    {


        // Player movement
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed * moveVertical);
        transform.Rotate(Vector3.up * Time.fixedDeltaTime * rotationSpeed * moveHorizontal);



        // Limit player position x
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }else if (transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }else if (transform.position.z > zRange){
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }else if (transform.position.z < -zRange){
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }





    }
    
    void spawnProjectile(){
        // Spawn projectile
        if (Input.GetKeyDown(KeyCode.Space)){
            int projectileIndex = Random.Range(0,projectilePrefab.Length);
            Instantiate(projectilePrefab[projectileIndex], transform.position, projectilePrefab[projectileIndex].transform.rotation);
        }
    }
}
