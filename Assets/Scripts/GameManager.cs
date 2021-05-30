using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public AddManager ad;
   // public TestAdmob testAdmob;
    
    public static bool _GameOver_;
    public static bool dificultyEasy;
    public static bool dificultyMedium;
    public static bool dificultyHard;
    public static bool coinsRegime;
    public static bool isAdLoadedOnce = false;

    private int LoadThisScene;

    public GameObject m_on, m_off;

    void Start()
    {        
        LoadThisScene = SceneManager.GetActiveScene().buildIndex;
         Time.timeScale = 1;
        _GameOver_ = false;

        dificultyEasy = false;
        dificultyMedium = false;
        dificultyHard = false;
        coinsRegime = false;

        if (PlayerPrefs.GetString("Music") == "no")
        {
            m_on.SetActive(false);
            m_off.SetActive(true);
        }
        else
        {
            m_on.SetActive(true);
            m_off.SetActive(false);
        }
    }

    void Update()
    {
        if (_GameOver_)
        {
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void GameOver()
    {
        _GameOver_ = true;

        Time.timeScale = 0;
        //AddManager.Instance.showInterstitial();        
    }

    public void DificultyEasy()
    {
        PlayMusicWhenIconisOn("ClickOnButtonAudio");

        SceneManager.LoadScene("Fb1");
        //AddManager.Instance.ShowBanner();
        //testAdmob.LoadRewardBasedAd();
        //testAdmob.ShowRewardBasedAd();

        dificultyEasy = true;
        dificultyMedium = false;
        dificultyHard = false;
        coinsRegime = false;
    }

    public void DificultyMedium()
    {
        PlayMusicWhenIconisOn("ClickOnButtonAudio");

        SceneManager.LoadScene("Fb2");
        //AddManager.Instance.ShowBanner();
        //testAdmob.LoadRewardBasedAd();
        //testAdmob.ShowRewardBasedAd();

        dificultyEasy = false;
        dificultyMedium = true;
        dificultyHard = false;
        coinsRegime = false;
    }
    public void DificultyHard()
    {
        PlayMusicWhenIconisOn("ClickOnButtonAudio");

        SceneManager.LoadScene("Fb3");
        //AddManager.Instance.ShowBanner();
        //testAdmob.LoadRewardBasedAd();
        //testAdmob.ShowRewardBasedAd();

        dificultyEasy = false;
        dificultyMedium = false;
        dificultyHard = true;
        coinsRegime = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        //GPGDemo.Instance.LogIn();        

        PlayMusicWhenIconisOn("ClickOnButtonAudio");
    }

    public void RestartGameFunction()
    {
        SceneManager.LoadScene(LoadThisScene);

        PlayMusicWhenIconisOn("ClickOnButtonAudio");
    }

    public void OnMouseButtondown()
    {
        PlayMusicWhenIconisOn("ClickOnButtonAudio");

        if (PlayerPrefs.GetString("Music") != "no")
        {
            PlayerPrefs.SetString("Music", "no");
            m_on.SetActive(false);
            m_off.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetString("Music", "yes");

            m_on.SetActive(true);
            m_off.SetActive(false);
        }
    }

    public void PlayMusicWhenIconisOn(string music)
    {
        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find(music).GetComponent<AudioSource>().Play();
        }
    }
}
