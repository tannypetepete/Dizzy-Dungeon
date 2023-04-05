using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;
    void Update()
    {
        
    }
    void MoveUp()
    {
        Debug.Log("moving up");
        rigidbody.velocity = new Vector2(0, speed);
    }
    void MoveDown()
    {
        Debug.Log("moving down");
        rigidbody.velocity = new Vector2(0, -speed);
    }
    void MoveLeft()
    {
        Debug.Log("moving left");
        rigidbody.velocity = new Vector2(-speed, 0);
    }
    void MoveRight()
    {
        Debug.Log("moving right");
        rigidbody.velocity = new Vector2(speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Finish")){ 
            Debug.Log("Level Win!");
            SceneManager.LoadScene("Main Menu");
        }
    }
}
