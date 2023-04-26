using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    AudioSource bgMusic;
    public AudioClip musicClip;
    public float globalVolume;
    public float bgmVolume;
    // Start is called before the first frame update
    void Start()
    {

        bgMusic = GetComponent<AudioSource>();
        globalVolume = PlayerPrefs.GetFloat("globalVolume");
        bgmVolume = PlayerPrefs.GetFloat("bgmVolume") * .5f;

        //AudioListener.volume = globalVolume;
        bgMusic.volume = bgmVolume;
        bgMusic.clip = musicClip;
        bgMusic.loop = true;
        bgMusic.Play();
    }
}
