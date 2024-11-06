using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float movement;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

        Flip();
    }

    void FixedUpdate()
    {
        rb.position = new Vector2(movement * moveSpeed, rb.position.y);
    }

    private void Flip()
    {
        if(isFacingRight && movement < 0f || isFacingRight && movement > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}

