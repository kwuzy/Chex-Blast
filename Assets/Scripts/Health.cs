using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    
    private int health;
    private int maxHealth;

    private int[] healthQuartiles = {0,0,0};

    public Health(int health) 
    {
        this.health = health;
        this.maxHealth = health;
        this.healthQuartiles[0] = 5000;
    }

    public int GetHealth() {
        return health;
    }

    public int GetMaxHealth() {
        return maxHealth;
    }

    public int[] GetHealthQuartiles() {
        return healthQuartiles;
    }


    public void Damage(int amount) {
        health -= amount;
    }
}
