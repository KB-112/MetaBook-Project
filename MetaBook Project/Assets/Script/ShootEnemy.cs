using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public Transform gunEnd;
    public LineRenderer lineRenderer;
    public float shootDistance = 100f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        int layerMask = LayerMask.GetMask("Enemy"); // Change "Enemy" to your desired layer name
        RaycastHit hit;
        if (Physics.Raycast(gunEnd.position, gunEnd.forward, out hit, shootDistance, layerMask))
        {
            Debug.Log("Hit: " + hit.transform.name);

            // Check if the hit object is on the "Enemy" layer
            if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                Debug.Log("hit");
                // Destroy the hit object's prefab
                Destroy(hit.transform.gameObject);
            }

            // Visualize the ray
            lineRenderer.SetPosition(0, gunEnd.position);
            lineRenderer.SetPosition(1, hit.point);
        }
        else
        {
            // If the ray doesn't hit anything, just visualize it shooting into the distance
            lineRenderer.SetPosition(0, gunEnd.position);
            lineRenderer.SetPosition(1, gunEnd.position + gunEnd.forward * shootDistance);
        }
    }


}
