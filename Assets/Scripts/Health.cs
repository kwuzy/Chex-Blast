using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health
{
    
    private int health;
    private int maxHealth;

    private int[] healthQuartiles = {0,0,0};

    public Health(int health) 
    {
        this.health = health;
        this.maxHealth = health;

        var quarterHealth = (decimal)maxHealth / 4;
        for (int i = 0; i < 3; i++)
        {
            this.healthQuartiles[i] = (int)Math.Ceiling(((decimal)i + 1) * quarterHealth);
        }
        if (healthQuartiles[2] == maxHealth) 
        {
            this.healthQuartiles[2] -= 1;
        }
        
    }

    public int CurrentHealth {
        get {return health;}
        set {health = value;}
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
