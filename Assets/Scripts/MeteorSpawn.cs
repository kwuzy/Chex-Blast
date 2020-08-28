using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MeteorSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject meteorPrefab;
    public float spawnForce = 1f;

    public float spawnTimer = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0 ; i < 2 ; i ++)
        {
            GameObject meteor = Instantiate(meteorPrefab, spawnPoint.position, spawnPoint.rotation);
            Rigidbody2D rb = meteor.GetComponent<Rigidbody2D>();
            rb.AddForce(spawnPoint.up * spawnForce, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
