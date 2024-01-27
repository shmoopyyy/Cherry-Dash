using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private float TrampolineJump = 10;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Trampoline potentialTrampoline = collision.gameObject.GetComponent<Trampoline>();

        if (potentialTrampoline != null)
        {
            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, TrampolineJump);
            potentialTrampoline.SendMessage("PlayTrampAnimation");
        }

    }
}
