using UnityEngine;

public class Target : MonoBehaviour {

    void Update() {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) {
            transform.position = mousePosition;
        }
    }
}
