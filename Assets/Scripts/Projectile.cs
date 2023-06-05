using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float topBound = 10f;
    public float projetileSpeed;
    [SerializeField] private GameObject player;
    private Quaternion rotationAngle;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rotationAngle = player.transform.rotation;
    }

    void Update()
    {
        transform.Translate(rotationAngle * Vector3.forward * Time.deltaTime * projetileSpeed);
        
        if (transform.position.z > topBound){
            Destroy(gameObject);
        }
    }
}
