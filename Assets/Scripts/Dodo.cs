using UnityEngine;

public class Dodo : MonoBehaviour
{

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;     
        transform.Rotate(0,0,0);
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        transform.Rotate(0,0,0);
    }

    private void OnMouseDrag() {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(newPosition.x,(float)-3.884643);
        transform.Rotate(0,0,0);
    }
}
