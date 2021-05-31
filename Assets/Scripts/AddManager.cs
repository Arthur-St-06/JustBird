using UnityEngine;
using admob;

public class AddManager : MonoBehaviour
{
    public static AddManager Instance { set; get; }
    public Admob ad;
    
    //string appID="";
     string bannerID = "";
    string videoID = "";
    //string interstitialID = "";
    //string videoID = "";
    //string nativeBannerID = "";
    void Awake()
    {
        Debug.Log("Awake is called!----------");
        Instance = this;
        initAdmob();
    }

    void Start()
    {
        Debug.Log("start unity demo-------------");

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log(KeyCode.Escape + "-----------------");
        }
    }

    void initAdmob()
    {
#if UNITY_IOS
        		// appID="ca-app-pub-3940256099942544~1458002511";
				 bannerID="ca-app-pub-3940256099942544/2934735716";
				 interstitialID="ca-app-pub-3940256099942544/4411468910";
				 videoID="ca-app-pub-3940256099942544/1712485313";
				 nativeBannerID = "ca-app-pub-3940256099942544/3986624511";
#elif UNITY_ANDROID
        //appID="ca-app-pub-3940256099942544~3347511713";
         // bannerID = "ca-app-pub-3940256099942544/6300978111";
        //bannerID = "ca-app-pub-8406135989508722/3708893457";
        //interstitialID = "ca-app-pub-8406135989508722/9298726518";
        videoID = "ca-app-pub-3940256099942544/5224354917";
        //nativeBannerID = "ca-app-pub-3940256099942544/2247696110";
#endif
        AdProperties adProperties = new AdProperties();
        adProperties.isTesting(false);
        adProperties.isAppMuted(false);
        adProperties.isUnderAgeOfConsent(false);
        //adProperties.appVolume(100);
        adProperties.maxAdContentRating(AdProperties.maxAdContentRating_G);
        string[] keywords = { "diagram", "league", "brambling" };
        adProperties.keyworks(keywords);

        ad = Admob.Instance();
        //ad.bannerEventHandler += onBannerEvent;
        //ad.interstitialEventHandler += onInterstitialEvent;
        //ad.rewardedVideoEventHandler += onRewardedVideoEvent;
       //ad.nativeBannerEventHandler += onNativeBannerEvent;
        ad.initSDK(adProperties);//reqired,adProperties can been null                          
    }

//    public void showInterstitial()
//    {
//#if UNITY_EDITOR
//        Debug.Log("showInterstitial");
//#elif UNITY_ANDROID

//        if (ad.isInterstitialReady())
//        {
//            ad.showInterstitial();
//        }
//        else
//        {
//            ad.loadInterstitial(interstitialID);
//        }
//#endif
//    }

    public void ShowBanner()
    {
#if UNITY_EDITOR
        Debug.Log("ShowBanner");
#elif UNITY_ANDROID
        
        Admob.Instance().loadRewardedVideo(videoID);
#endif
    }

    //Admob.Instance().showBannerRelative(bannerID, AdSize.FULL_BANNER, AdPosition.TOP_CENTER);

    //    public void RemoveBanner()
    //    {
    //#if UNITY_EDITOR
    //        Debug.Log("RemoveBanner");
    //#elif UNITY_ANDROID
    //            Admob.Instance().removeBanner(); 
    //#endif
    //    }
    //void OnGUI()
    //{
    //    //if (GUI.Button(new Rect(120, 0, 100, 60), "showInterstitial"))
    //    //{
    //    //    Debug.Log("touch inst button -------------");
    //    //    if (ad.isInterstitialReady())
    //    //    {
    //    //        ad.showInterstitial();
    //    //    }
    //    //    else
    //    //    {
    //    //        ad.loadInterstitial(interstitialID);
    //    //    }
    //    //}
    //    //if (GUI.Button(new Rect(0, 0, 100, 60), "showRewardVideo"))
    //    //{
    //    //    Debug.Log("touch video button -------------");
    //    //    if (ad.isRewardedVideoReady())
    //    //    {
    //    //        ad.showRewardedVideo();
    //    //    }
    //    //    else
    //    //    {
    //    //        ad.loadRewardedVideo(videoID);
    //    //    }
    //    //}
    //    //if (GUI.Button(new Rect(0, 100, 100, 60), "showbanner"))
    //    //{
    //    //    Admob.Instance().showBannerRelative(bannerID, AdSize.SMART_BANNER, AdPosition.BOTTOM_CENTER);
    //    //}
    //    if (GUI.Button(new Rect(0, 100, 100, 60), "showbannerABS"))
    //    {
    //        Admob.Instance().showBannerRelative(bannerID, AdSize.BANNER, AdPosition.BOTTOM_CENTER);
    //    }
    //    //if (GUI.Button(new Rect(240, 100, 100, 60), "removebanner"))
    //    //{
    //    //    Admob.Instance().removeBanner();
    //    //    Admob.Instance().removeBanner("mybanner");
    //    //}

    //    //if (GUI.Button(new Rect(0, 200, 100, 60), "showNative"))
    //    //{
    //    //    Admob.Instance().showNativeBannerRelative(nativeBannerID, new AdSize(320, 280), AdPosition.BOTTOM_CENTER);
    //    //}
    //    //if (GUI.Button(new Rect(120, 200, 100, 60), "showNativeABS"))
    //    //{
    //    //    Admob.Instance().showNativeBannerAbsolute(nativeBannerID, new AdSize(-1, 132), 0, 300);
    //    //}
    //    //if (GUI.Button(new Rect(240, 200, 100, 60), "removeNative"))
    //    //{
    //    //    Admob.Instance().removeNativeBanner();
    //    //}
    //}
    ////void onInterstitialEvent(string eventName, string msg)
    ////{
    ////    Debug.Log("handler onAdmobEvent---" + eventName + "   " + msg);
    ////    if (eventName == AdmobEvent.onAdLoaded)
    ////    {
    ////        Admob.Instance().showInterstitial();
    ////    }
    ////}
    //void onBannerEvent(string eventName, string msg)
    //{
    //    Debug.Log("handler onAdmobBannerEvent---" + eventName + "   " + msg);
    //}
    ////void onRewardedVideoEvent(string eventName, string msg)
    ////{
    ////    Debug.Log("handler onRewardedVideoEvent---" + eventName + "  rewarded: " + msg);
    ////}
    //void onNativeBannerEvent(string eventName, string msg)
    //{
    //    Debug.Log("handler onAdmobNativeBannerEvent---" + eventName + "   " + msg);
    //}
}
