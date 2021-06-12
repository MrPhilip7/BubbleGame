using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTiltingMovingPlayer : MonoBehaviour {
    private Rigidbody2D rb;
    private float dirX;
    private float moveSpeed = 20f;

    // Start is called before the first frame update
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update() {
        dirX = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(transform.position.x, transform.position.y);
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(dirX, 0f);
    }
}