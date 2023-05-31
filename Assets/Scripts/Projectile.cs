using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float topBound = 10f;
    public float projetileSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * projetileSpeed);
        
        if (transform.position.z > topBound){
            Destroy(gameObject);
        }
    }
}
