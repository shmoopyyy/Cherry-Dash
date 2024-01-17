using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variables
    public float runSpeed;
    public float jumpSpeed;
    public float dashSpeed;
    public float dashDuration;
    public float dashCooldown;
    bool isDashing;
    public LayerMask groundMask;
    private Rigidbody2D rigidBody;
    private BoxCollider2D boxCollider;



    // Start is called before the first frame update
    void Start()
    { 
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDashing)
        {
            return;
        }
        float horizontalInputs = Input.GetAxis("Horizontal");

        rigidBody.velocity = new Vector2(runSpeed * horizontalInputs, rigidBody.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(Dash());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Fruit potentialFruit = collision.gameObject.GetComponent<Fruit>();

        if (potentialFruit != null)
        {
            Destroy(potentialFruit.gameObject);
        
        }
    }

    bool IsGrounded()
    {
        bool isGrounded = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundMask);
        return isGrounded;
    }

    IEnumerator Dash()
    { 
        isDashing = true;
        float horizontalInputs = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(dashSpeed * horizontalInputs, dashSpeed * rigidBody.velocity.y);
        yield return new WaitForSeconds(dashDuration);
        isDashing = false;
    }
}
