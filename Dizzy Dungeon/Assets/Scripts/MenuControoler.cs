using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuControoler : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip gameAudio;
    public AudioClip GameWinAudio;
    public GameObject gameWin;
    public GameObject pauseButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Audio.PlayOneShot(GameWinAudio, 2f);
            collision.gameObject.SetActive(false);
            //Destroy(collision.gameObject);
            StartCoroutine(gameWinPanel());
            pauseButton.SetActive(false);
            //SceneManager.LoadScene("Main Menu");
        }
    }

    IEnumerator gameWinPanel()
    {
        yield return new WaitForSeconds(0.5f);
        gameWin.SetActive(true);
        Audio.PlayOneShot(gameAudio, 2f);
        //SwipeDectection.Movement = false;
    }
}

