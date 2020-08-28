using UnityEngine;

public class Dodo : MonoBehaviour
{
    private void OnMouseDown() //change to touch for app
    {
        GetComponent<SpriteRenderer>().color = Color.red;     
    }

    private void OnMouseUp() //change to touch for app
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void OnMouseDrag() //change to touch for app
    {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(newPosition.x,(float)-3.9);
    }
    private void Update() {
        transform.rotation = Quaternion.identity;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag.Equals("BulletCollidable")) {
            Debug.Log("i've hit the bird");
        }
    }
}
