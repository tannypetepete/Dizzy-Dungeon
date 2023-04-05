using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBreaker : MonoBehaviour
{
    public GameObject manager;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.transform.CompareTag("Player"))
        {
            manager.gameObject.SendMessage("Restart");
        }
    }
}
