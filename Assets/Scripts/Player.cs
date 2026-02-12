using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    Vector2 movement;

    void Start() {
        
    }

    void FixedUpdate() {
        rb.linearVelocity = new Vector2(movement.x * speed, movement.y * speed);
    }

    public void Move(InputAction.CallbackContext ctx) {
        movement = ctx.ReadValue<Vector2>();
    }
}
