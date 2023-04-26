using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Sprite playerSprite;
    public static bool canMove = true;
    Rigidbody2D rigid;
    public float speed;
    public GameObject gameOver;
    public GameObject gameWin;
    public GameObject pauseButton;
    public static bool canMoveLeft = true;
    public static bool canMoveright = true;
    public static bool canMoveUp = true;
    public static bool canmoveDown = true;

    public AudioSource Audio;
    public AudioClip gameAudio;

    Vector3 posPlayer;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

        canMove = true;
        canmoveDown = true;
        canMoveUp = true;
        canMoveright = true;
        canMoveLeft = true;
        //posPlayer = transform.position;
      //  Debug.Log("Player Position" + posPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        //pos = transform.position;
        //pos.x = Mathf.Clamp(pos.x, -2f, 2f);
        //transform.position = pos;
    }

    public void MoveUp()
    {
        Debug.Log("canMove" + canMove);
        Debug.Log("canMoveup" + canMoveUp);
        Debug.Log("canMoveDown" + canmoveDown);
        Debug.Log("canMoveleft" + canMoveLeft);
        Debug.Log("canMoveRight" + canMoveright);
        if (canMoveUp && canMove)
        {
            
            // rigid.velocity = transform.up *speed;
            rigid.AddForce(Vector2.up * speed);
            canMove = false;
            //canMoveUp = false;
            //canmoveDown = true;
            //canMoveright = true;
            //canMoveLeft = true;
          // StartCoroutine(Delay());
        }
        else
        {
            canMove = true;
            Debug.Log("Player");
        }
    }

    public void MoveDown()
    {
        Debug.Log("canMove" + canMove);
        Debug.Log("canMoveup" + canMoveUp);
        Debug.Log("canMoveDown" + canmoveDown);
        Debug.Log("canMoveleft" + canMoveLeft);
        Debug.Log("canMoveRight" + canMoveright);
        if (canmoveDown && canMove)
        {
            
            //rigid.velocity = -transform.up * speed;
            rigid.AddForce(Vector2.down * speed);
            canMove = false;
            //canmoveDown = false;
            //canMoveUp = true;
            //canMoveLeft = true;
            //canMoveright = true;
            //StartCoroutine(Delay());
        }
        else
        {
            canMove = true;
            Debug.Log("Player");
        }
    }
    public void MoveLeft()
    {
        Debug.Log("canMove" + canMove);
        Debug.Log("canMoveup" + canMoveUp);
        Debug.Log("canMoveDown" + canmoveDown);
        Debug.Log("canMoveleft" + canMoveLeft);
        Debug.Log("canMoveRight" + canMoveright);
        if (canMoveLeft && canMove)
        {
           
            // rigid.velocity = -transform.right * speed;
            rigid.AddForce(Vector2.left * speed);
            canMove = false;
            //canMoveLeft = false;
            //canMoveright = true;
            //canMoveUp = true;
            //canmoveDown = true;
            

           // StartCoroutine(Delay());
        }
        else
        {
            canMove = true;
            Debug.Log("Player");
        }
    }

    public void MoveRight()
    {
        Debug.Log("canMove" + canMove);
        Debug.Log("canMoveup" + canMoveUp);
        Debug.Log("canMoveDown" + canmoveDown);
        Debug.Log("canMoveleft" + canMoveLeft);
        Debug.Log("canMoveRight" + canMoveright);
        if (canMoveright && canMove)
        {
        //    Debug.Log("This is beng called positive");
           
            //rigid.velocity = transform.right;
            rigid.AddForce(Vector2.right * speed);
            canMove = false;
            //canMoveright = false;
            //canMoveLeft = true;
            //canmoveDown = true;
            //canMoveUp = true;
         //   StartCoroutine(Delay());
        }else
        {
            canMove = true;
            Debug.Log("Player");
        }
    }

    





    void OnCollisionEnter2D(Collision2D OtherObject)
    {
        switch (OtherObject.gameObject.tag)
        {
            case "wallTop":
                Debug.Log("This is beng called top");
                rigid.velocity = Vector2.zero;
                canMove = true;
                canMoveUp = false;
                canmoveDown = true;
                canMoveLeft = true;
                canMoveright = true;
                break;
            case "wallEnd":
                Debug.Log("This is beng called bottom");
                rigid.velocity = Vector2.zero;
                canMove = true;
                canMoveUp = true;
                canmoveDown = false;
                canMoveLeft = true;
                canMoveright = true;
                break;
            case "wallLeft":
                Debug.Log("This is beng called left");
                rigid.velocity = Vector2.zero;
                canMove = true;
                canMoveUp = true;
                canmoveDown = true;
                canMoveLeft = false;
                canMoveright = true;
                break;
            case "wallRight":
                Debug.Log("This is beng called right");
                rigid.velocity = Vector2.zero;
                canMove = true;
                canMoveUp = true;
                canmoveDown = true;
                canMoveLeft = true;
                canMoveright = false;
                break;
            ////case "Trap":

            ////    rigid.velocity = Vector2.zero;
            ////    Destroy(gameObject);
            ////    StartCoroutine(Delay());
            ////   //gameOver.SetActive(true);
            ////    pauseButton.SetActive(false);
            ////    //  SceneManager.LoadScene("Main Menu");
            ////    break;
            case "Enemy":
              //  StartCoroutine(Delay());
                rigid.velocity = Vector2.zero;
                gameObject.SetActive(false);
                gameOver.SetActive(true);
                Audio.PlayOneShot(gameAudio, 2f);
                pauseButton.SetActive(false);
                
                // SceneManager.LoadScene("Main Menu");
                break;
            default:
               rigid.velocity = Vector2.zero;
                canMove = true;
                canMoveUp = true;
                canmoveDown = true;
                canMoveLeft = true;
                canMoveright = true;
                break;
        }

        
    }






    //public void RetryLevel()
    //{
    //    gameObject.SetActive(true);
    //    transform.position = posPlayer;
    //}

    //else if (collision.gameObject.CompareTag("Trap"))
    //{
    //    Destroy(gameObject);
    //    audio.PlayOneShot(gameOverAudio, 2f);
    //   // StartCoroutine(Delay());
    //    gameOver.SetActive(true);

    //    pauseButton.SetActive(false);
    //    // SceneManager.LoadScene("Main Menu");
    //}
    /*  else if (collision.gameObject.CompareTag("Enemy"))
      {
          Destroy(gameObject);
          gameOver.SetActive(true);
      }*/

    /*  private void OnCollisionEnter(Collision collision)
      {
          if(collision.gameObject.tag == "Enemy")
          {
              Debug.Log("Collison");
              Destroy(gameObject);
          }
      }*/
}

