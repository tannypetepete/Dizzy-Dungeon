using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    #region MiscFunctions
    public void SetAll(float global, float bgm)
    {
        PlayerPrefs.SetFloat("globalVolume", global);
        PlayerPrefs.SetFloat("bgmVolume", bgm);
        PlayerPrefs.Save();
    }

    public float loadGlobal()
    {
        float globalSFX = PlayerPrefs.GetFloat("globalVolume");
        return globalSFX;
    }

    public float loadBGM()
    {
        float bgm = PlayerPrefs.GetFloat("bgmVolume");
        return bgm;
    }
    #endregion
}
