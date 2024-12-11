using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 1f;


    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        MoveMent();
    }

    void MoveMent()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            //spriteRenderer.flipX = false;
            FlipHitbox(true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            //spriteRenderer.flipX = true;
            FlipHitbox(false);
        }

    }
    
    void FlipHitbox(bool flipRight)
    {
        Vector3 hitboxScale = transform.localScale;

        if (flipRight)
        {
            hitboxScale.x = Mathf.Abs(hitboxScale.x);
        }
        else
        {
            hitboxScale.x = -Mathf.Abs(hitboxScale.x);
        }

        transform.localScale = hitboxScale;
    }

  
}

