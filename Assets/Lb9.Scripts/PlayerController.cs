using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float JumpForce = 10f;
    public static Action playerCollision;

    private Rigidbody2D rb;
    private CircleCollider2D circlecollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        circlecollider = GetComponent<CircleCollider2D>();
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * JumpForce;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Jump();
            playerCollision?.Invoke();
        }
        else if (collision.gameObject.tag == "FirstPlatform")
        {
            Jump();
            playerCollision?.Invoke();
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Under")
        {
            StartCoroutine(UnderBlock());
        }
    }

    IEnumerator UnderBlock()
    {
        circlecollider.enabled = false;
        yield return new WaitForSecondsRealtime(0.7f);
        circlecollider.enabled = true;
    }
}
