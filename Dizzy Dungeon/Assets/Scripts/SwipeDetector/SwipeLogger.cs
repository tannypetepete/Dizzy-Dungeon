using UnityEngine;

public class SwipeLogger : MonoBehaviour
{
    public GameObject player;
    public GameObject[] enemies;
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
            foreach(GameObject e in enemies)
            {
                e.gameObject.SendMessage("MoveUp");
            }
        }
        if (data.Direction == SwipeDirection.Down)
        {
            player.gameObject.SendMessage("MoveDown");
            foreach (GameObject e in enemies)
            {
                e.gameObject.SendMessage("MoveDown");
            }
        }
        if (data.Direction == SwipeDirection.Left)
        {
            player.gameObject.SendMessage("MoveLeft");
            foreach (GameObject e in enemies)
            {
                e.gameObject.SendMessage("MoveLeft");
            }
        }
        if (data.Direction == SwipeDirection.Right)
        {
            player.gameObject.SendMessage("MoveRight");
            foreach (GameObject e in enemies)
            {
                e.gameObject.SendMessage("MoveRight");
            }
        }
    }
}