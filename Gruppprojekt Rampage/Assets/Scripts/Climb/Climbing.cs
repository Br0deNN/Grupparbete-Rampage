using UnityEngine;

public class Climbing : MonoBehaviour
{
    private float vertical;
    private float speed = 8f;
    private bool isBuilding;
    private bool isClimbing;

    [SerializeField] Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");

        if (isBuilding && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 4f;
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Building"))
        {
            isBuilding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Building"))
        {
            isBuilding = false;
            isClimbing = false;
        }
    }
}
