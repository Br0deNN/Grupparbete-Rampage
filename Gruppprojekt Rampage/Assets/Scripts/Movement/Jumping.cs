using UnityEngine;

public class Jumping : MonoBehaviour
{

    [SerializeField] float jumpForce = 10f;
    [SerializeField] CircleCollider2D groundCheck; 
    [SerializeField] bool grounded;
    private Rigidbody2D rb;
    private bool jumpRequested;
    



    private void Awake()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            jumpRequested = true;
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (jumpRequested)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
            jumpRequested = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
}
