using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour
{
   public static bool canMove = true;
    Rigidbody2D rigid;
    public float speed = 20f;
    public static bool canMoveLeft = true;
    public static bool canMoveright = true;
    public static bool canMoveUp = true;
    public static bool canmoveDown = true;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        canMove = true;
        canmoveDown = true;
        canMoveUp = true;
        canMoveright = true;
        canMoveLeft = true;
    }
    public void MoveUp()
    {
        if (canMoveUp && canMove)
        {
            Debug.Log("Move up");
            rigid.AddForce(Vector2.up * speed);
            canMove = false;
        }
        else
        {
            canMove = true;
        }
    }

    public void MoveDown()
    {
        if (canmoveDown && canMove)
        {
            Debug.Log("Move Down by touch");
            rigid.AddForce(Vector2.down * speed);
            canMove = false;
        }
        else
        {
            canMove = true;
        }
    }
    public void MoveLeft()
    {
        if (canMoveLeft && canMove)
        {
            Debug.Log("Move Left");
            rigid.AddForce(Vector2.left * speed);
            canMove = false;
        }
        else
        {
            canMove = true;
        }
    }

    public void MoveRight()
    {
        if (canMoveright && canMove)
        {
            Debug.Log("Move right");
            rigid.AddForce(Vector2.right * speed);
            canMove = false;
        }
        else
        {
            canMove = true;
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

       /* else if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }*/
    }
}
