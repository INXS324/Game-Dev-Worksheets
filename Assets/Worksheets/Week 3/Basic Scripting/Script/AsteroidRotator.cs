using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotator : MonoBehaviour
{
    public float rotationSpeed = 30f; 

    void Update()
    {
        // Rotate the asteroid continuously
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
