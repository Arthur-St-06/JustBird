using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;


    public static bool _GameOver_;

    public static bool dificultyEasy;
    public static bool dificultyMedium;
    public static bool dificultyHard;

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

    public void GameOver()
    {
        _GameOver_ = true;
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }



    public void DificultyEasy()
    {
        SceneManager.LoadScene("Fb1");
        dificultyEasy = true;
        dificultyMedium = false;
        dificultyHard = false;

        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("ClickOnButtonAudio").GetComponent<AudioSource>().Play();
        }

    }

    public void DificultyMedium()
    {
        SceneManager.LoadScene("Fb2");
        dificultyEasy = false;
        dificultyMedium = true;
        dificultyHard = false;

        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("ClickOnButtonAudio").GetComponent<AudioSource>().Play();
        }

    }
    public void DificultyHard()
    {
        SceneManager.LoadScene("Fb3");
        dificultyEasy = false;
        dificultyMedium = false;
        dificultyHard = true;

        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("ClickOnButtonAudio").GetComponent<AudioSource>().Play();
        }

    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");

        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("ClickOnButtonAudio").GetComponent<AudioSource>().Play();
        }
    }

    public void RestartGameFunction()
    {
            SceneManager.LoadScene(LoadThisScene);

        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("ClickOnButtonAudio").GetComponent<AudioSource>().Play();
        }
    }

    public void OnMouseButtondown()
    {
        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("ClickOnButtonAudio").GetComponent<AudioSource>().Play();
        }

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
}
