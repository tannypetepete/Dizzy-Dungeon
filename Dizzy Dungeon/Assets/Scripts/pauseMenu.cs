using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseMenu : MonoBehaviour
{
    public GameObject pasueMenu;
    public GameObject PauseButton;
    public AudioSource Audio;
    public AudioClip gameAudio;
    GameObject SpwanPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pausegame()
    {
        Debug.Log("Pause Button ");
        Time.timeScale = 0f;
        pasueMenu.SetActive(true);
        Audio.PlayOneShot(gameAudio, 2f);
        PauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
        pasueMenu.SetActive(false);
        Time.timeScale = 1f;
        Audio.Stop();
        PauseButton.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Mainmenu()
    {
        Time.timeScale = 1f;

        SpwanPrefab = GameObject.FindGameObjectWithTag("Prefabs");
        Destroy(SpwanPrefab);
        
        SceneManager.LoadScene("Main Menu");
    }
}
