using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    
    [SerializeField] private float downBound = -13f;
    [SerializeField] private float topBound = 12f;
    public float animalSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * animalSpeed);

        
        if (transform.position.z < downBound && transform.position.z > topBound){
            Destroy(gameObject);
        }
    }
}
