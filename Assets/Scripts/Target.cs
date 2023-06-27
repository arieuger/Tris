using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    private Vector2 followSpot;
    [SerializeField] private float speed;

    void Start() {
        followSpot = transform.position;
    }

    void Update() {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) {
            followSpot = mousePosition;
        }

        transform.position = Vector2.MoveTowards(transform.position, followSpot, speed * Time.deltaTime);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        followSpot = transform.position;
    }
}
