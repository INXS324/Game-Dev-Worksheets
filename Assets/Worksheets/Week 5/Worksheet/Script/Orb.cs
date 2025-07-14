using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    public float force = 20f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Fire the orb forward when Space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.forward * force, ForceMode.Impulse);
        }
    }
}

