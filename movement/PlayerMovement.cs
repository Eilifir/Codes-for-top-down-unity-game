
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //---------------------References---------------------
    Rigidbody2D rb;
    //---------------------Variables---------------------
    Vector2 input;
    public float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        input = new Vector2(horizontal, vertical);
        input = input.normalized;
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = input * moveSpeed;
    }
}

