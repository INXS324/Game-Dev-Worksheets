using UnityEngine;

public class PlayerExploder : MonoBehaviour
{
    // Reference to Rigidbody for physics-based movement
    private Rigidbody rb;

    [Header("Movement Settings")]
    public float moveForce = 10.0f; // Movement strength

    [Header("Explosion Settings")]
    public float radius = 5.0f;     // Explosion radius
    public float power = 1000.0f;   // Explosion force

    [Header("Kick Settings")]
    public float kickStrength = 500f; // Force of the kick
    public float kickRange = 2f;      // How far in front the kick reaches

    void Start()
    {
        // Get the Rigidbody component on this GameObject
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Explosion trigger on E key
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckExplosion();
        }

        // Kick trigger on K key
        if (Input.GetKeyDown(KeyCode.K))
        {
            Kick();
        }
    }

    void FixedUpdate()
    {
        // Movement input using AddForce
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0, z) * moveForce;
        rb.AddForce(move);
    }

    void CheckExplosion()
    {
        // Find all nearby colliders within radius
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider hit in colliders)
        {
            Rigidbody hitRb = hit.GetComponent<Rigidbody>();

            // Only apply force to objects that have a Rigidbody and are not the player
            if (hitRb != null && hitRb != rb)
            {
                hitRb.AddExplosionForce(power, transform.position, radius, 3.0f);
            }
        }
    }

    void Kick()
    {
        // Center of the kick area, a short distance in front of the player
        Vector3 kickCenter = transform.position + transform.forward * kickRange;

        // Get all colliders in the kick zone
        Collider[] hitColliders = Physics.OverlapSphere(kickCenter, 1f);

        foreach (Collider col in hitColliders)
        {
            Rigidbody targetRb = col.GetComponent<Rigidbody>();

            // Apply a forward force to the object (but not to self)
            if (targetRb != null && targetRb != rb)
            {
                targetRb.AddForce(transform.forward * kickStrength, ForceMode.Impulse);
            }
        }
    }

 
}

