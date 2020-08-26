using UnityEngine;

public class Dodo : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;     
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void OnMouseDrag() 
    {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.y = gameObject.transform.position.y;
        transform.position = new Vector2(newPosition.x,newPosition.y);
        //transform.rotation  = Quaternion.identity;
    }
    private void Update() {
        transform.rotation = Quaternion.identity;
        //gameObject.transform.position.y = 1;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag.Equals("BulletCollidable")) {
            Debug.Log("i've hit the bird");
        }
    }
}
