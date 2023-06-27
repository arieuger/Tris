using UnityEngine;

public class Target : MonoBehaviour {

    [SerializeField] private float speed;


    void Start() {
        
    }

    void Update() {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) {
            transform.position = mousePosition;
        }
    }
}
