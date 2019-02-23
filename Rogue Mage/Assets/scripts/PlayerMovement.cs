using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 8f;
    public Joystick joystick;
    public Rigidbody2D body;

    private void Update() {
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical);

        if (moveVector != Vector3.zero) { 
            body.velocity = new Vector2(moveSpeed * joystick.Horizontal, moveSpeed * joystick.Vertical );
        } else {
            body.velocity = Vector2.zero;
        }
    }
}
