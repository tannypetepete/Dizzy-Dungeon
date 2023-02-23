using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Sprite playerSprite;
    private bool canMove = true;
    Rigidbody2D rigid;
    public float speed;


     // Start is called before the first frame update
     void Start()
     {
        rigid = GetComponent<Rigidbody2D>();
     }

    // Update is called once per frame
    void Update()
    {
      
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
        if(canMove)
        {
            rigid.AddForce(Vector2.right * speed);
            canMove = false;
        }
    }
    void OnCollisionEnter2D(Collision2D OtherObject)
    {
        switch (OtherObject.gameObject.tag)
        {
            case "Wall":
                rigid.velocity = Vector2.zero;
                canMove = true;
                break;
            case "Trap":
                rigid.velocity = Vector2.zero;
                SceneManager.LoadScene("Main Menu");
                break;
            case "Enemy":
                rigid.velocity = Vector2.zero;
                SceneManager.LoadScene("Main Menu");
                break;
            default:
                rigid.velocity = Vector2.zero;
                canMove = true;
                break;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            SceneManager.LoadScene("Main Menu");
        }
        else if (collision.gameObject.CompareTag("Trap"))
        {

            SceneManager.LoadScene("Main Menu");
        }
    }

}
