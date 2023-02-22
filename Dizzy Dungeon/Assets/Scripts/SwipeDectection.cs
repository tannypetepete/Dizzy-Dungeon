using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDectection : MonoBehaviour
{
    public PlayerController player;
    private Vector2 startPos;
    public int swipeSensitive = 120; //# of pixels needed to detect a swipe
    private bool fingerDown;
    private bool mouseDown;

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
            Debug.Log("Mouse Swipe");
        }

        if (fingerDown)
        {
            if (Input.touches[0].position.y >= startPos.y + swipeSensitive)
            {
                fingerDown = false;
                Debug.LogWarning("Swipe Up! Implement Player Movement.");
            }
            if (Input.touches[0].position.y <= startPos.y - swipeSensitive)
            {
                fingerDown = false;
                Debug.LogWarning("Swipe Down! Implement Player Movement.");
            }

            if (Input.touches[0].position.x >= startPos.x + swipeSensitive)
            {
                fingerDown = false;
                Debug.LogWarning("Swipe Right! Implement Player Movement.");
            }
            if (Input.touches[0].position.x <= startPos.x - swipeSensitive)
            {
                fingerDown = false;
                Debug.LogWarning("Swipe Left! Implement Player Movement.");
            }
        }

        if (mouseDown)
        {
            if (Input.mousePosition.y >= startPos.y + swipeSensitive)
            {
                mouseDown = false;
                player.SendMessage("MoveUp");
                Debug.LogWarning("Swipe Up! Implement Player Movement.");
            }
            if (Input.mousePosition.y <= startPos.y - swipeSensitive)
            {
                mouseDown = false;
                player.SendMessage("MoveDown");
                Debug.LogWarning("Swipe Down! Implement Player Movement.");
            }

            if (Input.mousePosition.x >= startPos.x + swipeSensitive)
            {
                mouseDown = false;
                player.SendMessage("MoveRight");
                Debug.LogWarning("Swipe Right! Implement Player Movement.");
            }
            if (Input.mousePosition.x <= startPos.x - swipeSensitive)
            {
                mouseDown = false;
                player.SendMessage("MoveLeft");
                Debug.LogWarning("Swipe Left! Implement Player Movement.");
            }
        }

        if(mouseDown && Input.GetMouseButtonUp(0))
        {
            mouseDown = false;
        }

    }
}
