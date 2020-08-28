using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Meteor : MonoBehaviour
{
    public Health hp;
    public SpriteRenderer spriteRenderer;
    public Sprite threeQuartersDamaged;
    public Sprite halfDamaged;
    public Sprite quarterDamaged;
    public TextMeshProUGUI healthTextComponent;
    public Canvas healthCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        hp = new Health(20);
    }
    void Update() {
        var quarterHealth = hp.GetHealthQuartiles()[0];
        var halfHealth = hp.GetHealthQuartiles()[1];
        var threeQuartersHealth = hp.GetHealthQuartiles()[2];

        //meteor damanged, shows damage, and gets destroyed
        if (hp.CurrentHealth <= 0 ){
            Destroy(gameObject);
        }
        else if(hp.CurrentHealth <= quarterHealth)
        {
            ChangeSprite(threeQuartersDamaged);
        }
        else if (hp.CurrentHealth <= halfHealth)
        {
            ChangeSprite(halfDamaged);
        }
        else if (hp.CurrentHealth <= threeQuartersHealth)
        {
            ChangeSprite(quarterDamaged);
        }

        //display the health as a number over the meteor and keep it stable
        healthCanvas.transform.rotation = Quaternion.Euler(0, 0, 0);
        healthTextComponent.text = hp.CurrentHealth.ToString();
    }

    void ChangeSprite(Sprite newSprite) {
        spriteRenderer.sprite = newSprite;
    }
}
