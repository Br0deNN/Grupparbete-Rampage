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

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Touch grass");
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Touching grass");
            grounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Collision");
        if (other.CompareTag("Ground"))
        {
            Debug.Log("True Collision");
            grounded = false;
        }
    }
}
