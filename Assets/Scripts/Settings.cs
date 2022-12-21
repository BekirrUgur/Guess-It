using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    public GameObject soundOn;
    public GameObject soundOff;
    public GameObject soundEffectOn;
    public GameObject soundEffectOff;
    public GameObject s30;
    public GameObject s60;
    public GameObject s90;

    public GameObject gameMusic;
    public AudioSource sfx;

    private int sfxControl;
    public void Start()
    {
        ConfigureSettings();
        sfxControl = PlayerPrefs.GetInt("GameSoundEffect");
    }
    public void SoundOn() 
    {
        soundOn.SetActive(true);
        soundOff.SetActive(false);
        gameMusic.SetActive(true);
        PlayerPrefs.SetInt("GameSound",1);
        SFXControl();
    }
    public void SoundOff()
    {
        soundOn.SetActive(false);
        soundOff.SetActive(true); 
        gameMusic.SetActive(false);
        PlayerPrefs.SetInt("GameSound", 0);
        SFXControl();
    }


    public void SoundEffectOn()
    {
        soundEffectOn.SetActive(true);
        soundEffectOff.SetActive(false);
        PlayerPrefs.SetInt("GameSoundEffect", 1);
        SFXControl();
    }
    public void SoundEffectOff()
    {
        soundEffectOn.SetActive(false);
        soundEffectOff.SetActive(true);
        PlayerPrefs.SetInt("GameSoundEffect", 0);
        SFXControl();
    }


    public void GameDuration30() 
    {
        s30.SetActive(true);
        s60.SetActive(false);
        s90.SetActive(false);
        PlayerPrefs.SetInt("GameTime", 0);
        SFXControl();
    }
    public void GameDuration60()
    {
        s30.SetActive(false);
        s60.SetActive(true);
        s90.SetActive(false);
        PlayerPrefs.SetInt("GameTime", 1);
        SFXControl();
    }
    public void GameDuration90()
    {
        s30.SetActive(false);
        s60.SetActive(false);
        s90.SetActive(true);
        PlayerPrefs.SetInt("GameTime", 2);
        SFXControl();
    }


    public void ConfigureSettings() 
    {
        int sound = PlayerPrefs.GetInt("GameSound");
        int soundEffect = PlayerPrefs.GetInt("GameSoundEffect");
        int duration = PlayerPrefs.GetInt("GameTime");

        if (sound == 0) 
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        }
        else 
        {
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        //---------------------------------------------
        if (soundEffect == 0) 
        {
            soundEffectOn.SetActive(false);
            soundEffectOff.SetActive(true);
        }
        else 
        {
            soundEffectOn.SetActive(true);
            soundEffectOff.SetActive(false);
        }
        //---------------------------------------------
        if (duration == 0) 
        {
            s30.SetActive(true);
            s60.SetActive(false);
            s90.SetActive(false);
        }
        else if (duration == 1) 
        {
            s30.SetActive(false);
            s60.SetActive(true);
            s90.SetActive(false);
        }
        else
        {
            s30.SetActive(false);
            s60.SetActive(false);
            s90.SetActive(true);

        }

    }
    public void SFXControl()
    {
        sfxControl = PlayerPrefs.GetInt("GameSoundEffect");
        if (sfxControl == 1) { sfx.Play(); } // SFX açýk mý kapalý mý kontrol ediyor.
        else { }
    }
}
