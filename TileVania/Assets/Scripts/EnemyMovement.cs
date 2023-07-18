using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    Rigidbody2D gooberRigidbody;

    void Start()
    {
        gooberRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        gooberRigidbody.velocity = new Vector2(moveSpeed, 0.0f);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
    }

    void FlipEnemyFacing()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(gooberRigidbody.velocity.x)), 1.0f);
    }
}
