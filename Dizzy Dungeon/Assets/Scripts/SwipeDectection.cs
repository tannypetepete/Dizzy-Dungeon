using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDectection : MonoBehaviour
{
    public static PlayerController player;
    private Vector2 startPos;
    public int swipeSensitive = 120; //# of pixels needed to detect a swipe
    private bool fingerDown;
    private bool mouseDown;
    public static bool Movement = true;

    private void Start()
    {
        Movement = true;
    }
    private void Update()
    {
        /* if (fingerDown = false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
         {
             startPos = Input.touches[0].position;
             fingerDown = true;
         }
        */

        //FOR TESTING, MOUSE INPUT FOR SWIPES;

      
            if (mouseDown == false && Input.GetMouseButtonDown(0))
            {
                startPos = Input.mousePosition;
                mouseDown = true;
            }
        if (Movement == true)
        {
            if (fingerDown)
            {
                if (Input.touches[0].position.y >= startPos.y + swipeSensitive)
                {
                    fingerDown = false;
                    Debug.LogWarning("Swipe Up! Implement Player Movement.");
                    Debug.Log("Swipe Up");
                }
                if (Input.touches[0].position.y <= startPos.y - swipeSensitive)
                {

                    fingerDown = false;
                    Debug.LogWarning("Swipe Down! Implement Player Movement.");
                    Debug.Log("Swipe Down");
                }

                if (Input.touches[0].position.x >= startPos.x + swipeSensitive)
                {
                    fingerDown = false;
                    Debug.LogWarning("Swipe Right! Implement Player Movement.");
                    Debug.Log("Swipe left");
                }
                if (Input.touches[0].position.x <= startPos.x - swipeSensitive)
                {
                    fingerDown = false;
                    Debug.LogWarning("Swipe Left! Implement Player Movement.");
                    Debug.Log("Swipe Right");
                }
            }
            
        }


        if (Movement == true)
        {
            if (mouseDown)

            {
                if (Input.mousePosition.y >= startPos.y + swipeSensitive)
                {
                    mouseDown = false;
                    BroadcastMessage("MoveUp");
                    Debug.Log("Swipe Up");
                }
                if (Input.mousePosition.y <= startPos.y - swipeSensitive)
                {
                    mouseDown = false;
                    BroadcastMessage("MoveDown");
                    Debug.Log("Swipe Down");
                }

                if (Input.mousePosition.x >= startPos.x + swipeSensitive)
                {
                    mouseDown = false;
                    BroadcastMessage("MoveRight");
                    Debug.Log("Swipe Right");
                }
                if (Input.mousePosition.x <= startPos.x - swipeSensitive)
                {
                    mouseDown = false;
                    BroadcastMessage("MoveLeft");
                    Debug.Log("Swipe left");
                }
            }
           
        }

        if (mouseDown && Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
        }

    }
  
}
