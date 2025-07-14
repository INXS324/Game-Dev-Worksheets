using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    // The amount of force to apply when a key is pressed
    public float force = 100f;

   
    private Rigidbody rb;

    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // When UpArrow is pressed, apply force forward 
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Firing forward");
            rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
        }

        // When DownArrow is pressed, apply force backward 
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Firing backward");
            rb.AddForce(Vector3.back * force, ForceMode.Impulse);
        }

        // When LeftArrow is pressed, apply force to the left 
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Firing left");
            rb.AddForce(Vector3.left * force, ForceMode.Impulse);
        }

        // When RightArrow is pressed, apply force to the right 
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Firing right");
            rb.AddForce(Vector3.right * force, ForceMode.Impulse);
        }

        // When Space is pressed, apply force upward 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Firing upward");
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
