using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Sprite playerSprite;
    private bool canMove = true;

   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void MoveUp()
    {

    }

    void MoveDown()
    {

    }
    void MoveLeft()
    {

    }

    void MoveRight()
    {

    }
    void OnCollisionEnter(Collision OtherObject){
        canMove = false;
    }
}
