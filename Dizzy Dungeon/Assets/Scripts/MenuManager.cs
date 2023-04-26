using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public float bgVolume, sfxVolume;
    AudioController audioControl;
    AudioSource source;
    public AudioClip bgmClip;
    public Slider mSlider;

    // Start is called before the first frame update
    void Start()
    {

        #region Audio
        audioControl = GetComponent<AudioController>();
        source = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("bgmVolume"))
        {
            bgVolume = PlayerPrefs.GetFloat("bgmVolume");
            
        }
        else
        {
            bgVolume = 1f;
            PlayerPrefs.SetFloat("bgmVolume", bgVolume);
        }

        if (PlayerPrefs.HasKey("globalVolume"))
        {
            sfxVolume = PlayerPrefs.GetFloat("globalVolume");
        }
        else
        {
            sfxVolume = 1f;
            PlayerPrefs.SetFloat("globalVolume", sfxVolume);
        }

        audioControl.SetAll(sfxVolume, bgVolume);

        mSlider.value = bgVolume;
        source.volume = bgVolume * .5f;
        source.clip = bgmClip;
        source.loop = true;
        source.Play();
        #endregion

    }

    #region Misc Functions
    public void StartGame(int level)
    {
        SceneManager.LoadScene("Level " + level);
    }

    public void adjustMusicVolume(float volume)
    {
        bgVolume = volume;
        source.volume = bgVolume * .5f;
        audioControl.SetAll(sfxVolume, bgVolume);
    }
    #endregion
}
