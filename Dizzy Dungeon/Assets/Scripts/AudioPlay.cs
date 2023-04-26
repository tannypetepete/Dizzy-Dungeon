using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
   // public GameObject player;
    public AudioSource Audio;
    public AudioClip gameAudio;
    public GameObject gameover;
    public AudioClip gameoverAudio;
    public GameObject pauseButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // gameover.SetActive(true);
            // Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            Audio.PlayOneShot(gameoverAudio, 2f);
            StartCoroutine(gameOverPanel());
            pauseButton.SetActive(false);

        }
    }


    //{
    //   

    //}

    IEnumerator gameOverPanel()
    {
        yield return new WaitForSeconds(0.8f);
        gameover.SetActive(true);
        Audio.PlayOneShot(gameAudio, 2f);
    }
    public void Retry()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
    }
}
