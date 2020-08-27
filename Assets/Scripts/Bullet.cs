using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag.Equals("BulletCollidable")) {
            Destroy(gameObject);
            var meteor = col.gameObject.GetComponent<Meteor>();
            meteor.hp.Damage(1);
        }
    }    
}
