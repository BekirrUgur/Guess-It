using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class AdmobInitialize : MonoBehaviour
{
    public Image loadBar;
    public TextMeshProUGUI loadText;
    private float prepareTime = 5;
    public void Start()
    {
        PlayerPrefs.SetInt("Initialize", 0);
        MobileAds.Initialize(initStatus => { });
        
    }
    
    public void Update() 
    {
        if (prepareTime > 0)
        {

            prepareTime -= Time.deltaTime;
            StartCoroutine(Loading());

        }
        else
        {
            
            SceneManager.LoadScene("Menu");
        }
    }
   
    
    public IEnumerator Loading()
    {
        yield return new WaitForSeconds(1f);
        loadBar.fillAmount += 0.25f;
        if (loadBar.fillAmount == 1f) 
        {
            StopCoroutine(Loading());
        }
    }
    
}
