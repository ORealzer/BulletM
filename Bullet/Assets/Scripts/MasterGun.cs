using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterGun : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        // Shoots if player clicks left mouse button
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Creates a bullet
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
