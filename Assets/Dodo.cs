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

    private void OnMouseDrag() {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(newPosition.x,(float)-3.884643);
    }
}
