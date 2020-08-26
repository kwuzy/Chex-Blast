using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject coconutPrefab;

    public float coconutForce = 20f;
    
    public float fireRate = (float)0.5;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            InvokeRepeating("Shoot", (float)0.001, fireRate);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            CancelInvoke("Shoot");    
        }
    }

    void Shoot()
    {
        GameObject coconut = Instantiate(coconutPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = coconut.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * coconutForce, ForceMode2D.Impulse);
        Destroy(coconut, 5f);
    }

}
