using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour
{
    bool canMove = true;
    Rigidbody2D rigid;
    public float speed = 20f;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    public void MoveUp()
    {
        if (canMove)
        {
            rigid.AddForce(Vector2.up * speed);
            canMove = false;
        }
    }

    public void MoveDown()
    {
        if (canMove)
        {
            rigid.AddForce(Vector2.down * speed);
            canMove = false;
        }
    }
    public void MoveLeft()
    {
        if (canMove)
        {
            rigid.AddForce(Vector2.left * speed);
            canMove = false;
        }
    }

    public void MoveRight()
    {
        if (canMove)
        {
            rigid.AddForce(Vector2.right * speed);
            canMove = false;
        }
    }
    void OnCollisionEnter2D(Collision2D OtherObject)
    {
        rigid.velocity = Vector2.zero;
        canMove = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            collision.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
