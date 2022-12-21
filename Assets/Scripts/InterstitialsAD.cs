using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class InterstitialsAD : MonoBehaviour
{
    private InterstitialAd initializeAD;
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.

        this.RequestInterstitial();
        
    }
    
    public void Update() 
    {
        if (PlayerPrefs.GetInt("interstitialsControl") == 1) 
        {
            if (this.initializeAD.IsLoaded()) 
            {
                Screen.orientation = ScreenOrientation.Portrait;
                PlayerPrefs.SetInt("interstitialsControl", 0);
                this.initializeAD.Show();
            }
        }
    
    }
    
    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string interstitialID = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif

        this.initializeAD = new InterstitialAd(interstitialID);
        AdRequest request = new AdRequest.Builder().Build();
        this.initializeAD.LoadAd(request);
        this.initializeAD.OnAdClosed += HandleOnAdClosed;
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        initializeAD.Destroy();
        SceneManager.LoadScene("Final");
    }
}
