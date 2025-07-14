using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player1 : MonoBehaviour
{
    void Start()
    {
        CheckLineOfSight();
    }

    void CheckLineOfSight()
    {
        // Find all enemies in the scene
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            Vector3 direction = enemy.transform.position - transform.position;

            // Draw debug line in Scene view
            Debug.DrawRay(transform.position, direction, Color.red, 2f);

            RaycastHit hit;

            // Cast ray toward enemy
            if (Physics.Raycast(transform.position, direction, out hit, direction.magnitude))
            {
                if (hit.collider.gameObject == enemy)
                {
                    // If the ray directly hits the enemy, turn it green
                    Renderer rend = enemy.GetComponent<Renderer>();
                    if (rend != null)
                    {
                        rend.material.color = Color.green;
                    }
                }
            }
        }
    }
}

