using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 50f;
    public Rigidbody rb;

    // Amount of damage the enemy inflicts
    public int damageAmount = 20;

    // Start is called before the first frame update
    void Start()
    {
        // Movement of the bullet
        rb.velocity = transform.forward * Speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves another object
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Get the Health component from the enemy object
            Target target = collision.gameObject.GetComponent<Target>();

            // Check if the Health component exists
            if (target != null)
            {
                print("exist");
                // Call the TakeDamage method on the Health component
                target.TakeDamage(damageAmount);
            }

            //Destroy bullet after hitting the enemy
            Destroy(gameObject);
        }
    }
}
