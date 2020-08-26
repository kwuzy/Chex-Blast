using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    
    private int health;
    private int maxHealth;

    public Health(int health) 
    {
        this.health = health;
        this.maxHealth = health;
    }

    public int GetHealth() {
        return health;
    }

    public int GetMaxHealth() {
        return maxHealth;
    }

    public void Damage(int amount) {
        health -= amount;
    }
}
