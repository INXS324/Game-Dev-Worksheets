using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmicCube : MonoBehaviour
{
    private Renderer rend;
    public Color activeColor = Color.green;
    public Color defaultColor = Color.red;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = defaultColor;
    }

    void OnCollisionEnter(Collision collision)
    {
        rend.material.color = activeColor;
    }

    void OnCollisionExit(Collision collision)
    {
        rend.material.color = defaultColor;
    }
}

