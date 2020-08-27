using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Meteor : MonoBehaviour
{
    public Health hp;
    public SpriteRenderer spriteRenderer;
    public Sprite threeQuartersDamaged;
    public Sprite halfDamaged;
    public Sprite quarterDamaged;
    
    // Start is called before the first frame update
    void Start()
    {
        hp = new Health(10);
        Debug.Log("this quartile: " + hp.GetHealthQuartiles());
    }
    void Update() {
        var currentHP = hp.GetHealth();
        var quarterHealth = (int)Math.Ceiling((decimal)hp.GetMaxHealth()) / 4;
        var halfHealth = (int)Math.Ceiling((decimal)hp.GetMaxHealth()) / 2;
        var threeQuartersHealth = (int)Math.Ceiling((decimal)hp.GetMaxHealth()) * 3 / 4;

        //meteor damanged, shows damage, and gets destroyed
        if (currentHP <= 0 ){
            Destroy(gameObject);
        }
        else if(currentHP <= quarterHealth)
        {
            ChangeSprite(threeQuartersDamaged);
        }
        else if (currentHP <= halfHealth)
        {
            ChangeSprite(halfDamaged);
        }
        else if (currentHP <= threeQuartersHealth)
        {
            ChangeSprite(quarterDamaged);
        }
    }

    void ChangeSprite(Sprite newSprite) {
        spriteRenderer.sprite = newSprite;
    }
}
