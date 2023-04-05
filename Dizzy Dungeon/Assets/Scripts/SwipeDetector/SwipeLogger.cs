using UnityEngine;

public class SwipeLogger : MonoBehaviour
{
    public GameObject player;
    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        Debug.Log("Swipe in Direction: " + data.Direction);
        if(data.Direction == SwipeDirection.Up)
        {
            player.gameObject.SendMessage("MoveUp");
        }
        if (data.Direction == SwipeDirection.Down)
        {
            player.gameObject.SendMessage("MoveDown");
        }
        if (data.Direction == SwipeDirection.Left)
        {
            player.gameObject.SendMessage("MoveLeft");
        }
        if (data.Direction == SwipeDirection.Right)
        {
            player.gameObject.SendMessage("MoveRight");
        }
    }
}