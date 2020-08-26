using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Health hp;
    public SpriteRenderer spriteRenderer;
    public Sprite mostDamaged;
    
    // Start is called before the first frame update
    void Start()
    {
        hp = new Health(10);
    }
    void Update() {
        if (hp.GetHealth() <= 0 ){
            Destroy(gameObject);
        }
        if(hp.GetHealth() < hp.GetMaxHealth() / 2)
        {
            ChangeSprite(mostDamaged);
        }
    }

    void ChangeSprite(Sprite newSprite) {
        spriteRenderer.sprite = newSprite;
    }
}
