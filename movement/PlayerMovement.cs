
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //---------------------References---------------------
    Rigidbody2D rb;
    //---------------------Variables---------------------
    Vector2 input;
    [SerializedField] float moveSpeed = 5f;    //If you're using the modular sprint/run script change this into public instead of [SerializedFiels]

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        input = new Vector2(horizontal, vertical);
        input = input.normalized;    //Normalize the vector so you move at the same speed in every direction.
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = input * moveSpeed;
    }
}

