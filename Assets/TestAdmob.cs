using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;

public class TestAdmob : MonoBehaviour
{
    /*private RewardBasedVideoAd _rewardBasedVideoAd;

    void Start()
    {
        _rewardBasedVideoAd = RewardBasedVideoAd.Instance;

        // Called when an ad request has successfully loaded.
        _rewardBasedVideoAd.OnAdLoaded += HandleRewardBasedVideoLoaded;
        // Called when an ad request failed to load.
        _rewardBasedVideoAd.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
        // Called when an ad is shown.
        _rewardBasedVideoAd.OnAdOpening += HandleRewardBasedVideoOpened;
        // Called when the ad starts to play.
        _rewardBasedVideoAd.OnAdStarted += HandleRewardBasedVideoStarted;
        // Called when the user should be rewarded for watching a video.
        _rewardBasedVideoAd.OnAdRewarded += HandleRewardBasedVideoRewarded;
        // Called when the ad is closed.
        _rewardBasedVideoAd.OnAdClosed += HandleRewardBasedVideoClosed;
        // Called when the ad click caused the user to leave the application.
        _rewardBasedVideoAd.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;

    }

    void Update()
    {
        
    }

    public void LoadRewardBasedAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            string adUnitId = "unexpected_platform";
#endif

        _rewardBasedVideoAd.LoadAd(new AdRequest.Builder().Build(), adUnitId);
    }

    public void ShowRewardBasedAd()
    {
        if (_rewardBasedVideoAd.IsLoaded())
        {
            _rewardBasedVideoAd.Show();
            Debug.Log("ad loaded");
        }
        else
        {
            Debug.Log("No ad");
        }
    }

    public event EventHandler<EventArgs> OnAdLoaded;
    public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;
    public event EventHandler<EventArgs> OnAdOpening;
    public event EventHandler<EventArgs> OnAdStarted;
    public event EventHandler<EventArgs> OnAdClosed;
    public event EventHandler<Reward> OnAdRewarded;
    public event EventHandler<EventArgs> OnAdLeavingApplication;

    public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
    {

    }

    public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {

    }

    public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
    {

    }

    public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
    {

    }

    public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
    {

    }

    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {

    }

    public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
    {

    }*/
}
