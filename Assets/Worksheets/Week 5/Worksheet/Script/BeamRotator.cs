using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamRotator : MonoBehaviour
{
    public float torqueStrength = 300f;

    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Rotate clockwise around Y-axis when Z is pressed
        if (Input.GetKeyDown(KeyCode.Z))
        {
            
            rb.AddTorque(Vector3.up * torqueStrength, ForceMode.Impulse);
        }

        // Rotate counter-clockwise around Y-axis when X is pressed
        if (Input.GetKeyDown(KeyCode.X))
        {
            
            rb.AddTorque(Vector3.down * torqueStrength, ForceMode.Impulse);
        }
    }
}

