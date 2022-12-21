using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager: MonoBehaviour
{

    public GameObject gameMusic;
    public AudioSource sfx;

    private int sfxControl;


    private void Start()
    {
        sfxControl = PlayerPrefs.GetInt("GameSoundEffect");

        int musicControl = PlayerPrefs.GetInt("GameSound");
        if (musicControl == 1)
        {
            gameMusic.SetActive(true);
        }
        else 
        {
            gameMusic.SetActive(false);
        }


        //if(sfxControl == 1) { sfx.Play(); }
        //else { }


    }

    #region General Button
    public void Menu()
    {
        SFXControl();
        StartCoroutine(CoMenu());
    }
    public void CategoriesPrepare()
    {
        SFXControl();
        StartCoroutine(CoCategoriesPrepare());
    }
    public void GoSettings() 
    {
        SFXControl();
        StartCoroutine(CoGoSettings());
        
    }
    #endregion

    #region Coroutines 
    // Sahne geçiþleri coroutine ile gecikmeli yapýlýyor týklama sesini çýkmasý için.
    public IEnumerator CoGoSettings()
    {
        // suspend execution for 0.1 seconds
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Settings");
    }

    public IEnumerator CoCategoriesPrepare()
    {
        // suspend execution for 0.1 seconds
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("PlayGame");
    }
    public IEnumerator CoMenu()
    {
        // suspend execution for 0.1 seconds
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Menu");
    }

    public IEnumerator CoCategories() // Categories
    {
        Debug.LogWarning("Coroutine çalýþtý");
        // suspend execution for 0.1 seconds
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("CategoriesPrepare");
    }



    #endregion 

    #region Categories
    public void Animals()
    {
        
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 0);
        StartCoroutine(CoCategories());
    }
    public void Basketball()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 1);
        StartCoroutine(CoCategories());
    }
    public void Lotr()
    {

        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 2);
        StartCoroutine(CoCategories());
    }
    public void Marvel()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 3);
        StartCoroutine(CoCategories());
    }
    public void Geography()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 4);
        StartCoroutine(CoCategories());
    }
    public void Professions()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 5);
        StartCoroutine(CoCategories());
    }
    public void Football()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 6);
        StartCoroutine(CoCategories());
    }
    public void Art()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 7);
        StartCoroutine(CoCategories());
    }
    public void Famous()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 8);
        StartCoroutine(CoCategories());
    }
    public void Countries()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 9);
        StartCoroutine(CoCategories());
    }
    public void Cartoon()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 10);
        StartCoroutine(CoCategories());
    }
    public void Winter()
    {
        SFXControl();

        PlayerPrefs.SetInt("CategoriesSelection", 11);
        StartCoroutine(CoCategories());
    }
    #endregion 

    public void SFXControl()
    {
        if (sfxControl == 1) { sfx.Play(); } // SFX açýk mý kapalý mý kontrol ediyor.
        else { }
    }
}
