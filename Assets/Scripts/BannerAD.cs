using UnityEngine;
using GoogleMobileAds.Api;

public class BannerAD : MonoBehaviour
{
    private BannerView bannerView;
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        if (PlayerPrefs.GetInt("Initialize") == 0) 
        {
            PlayerPrefs.SetInt("Initialize", 1);
        }
        else { }
        
        this.RequestBanner();
    }
    public void RequestBanner() 
    {
#if UNITY_ANDROID
        string bannerID = "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif
        this.bannerView = new BannerView(bannerID, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        this.bannerView.LoadAd(request);
    }
}
