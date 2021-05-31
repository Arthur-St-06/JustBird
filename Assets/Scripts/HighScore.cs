using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text HighScoreEasy;
    public Text HighScoreMedium;
    public Text HighScoreHard;

    void Update()
    {
        highScore("HighScoreEasy", HighScoreEasy);
        highScore("HighScoreMedium", HighScoreMedium);
        highScore("HighScoreHard", HighScoreHard);

        if (this.gameObject.tag == "HighScoreEasy")
        {
            HighScoreEasy.text = PlayerPrefs.GetInt("HighScoreEasy", 0).ToString();
        }

        if (this.gameObject.tag == "HighScoreMedium")
        {
            HighScoreMedium.text = PlayerPrefs.GetInt("HighScoreMedium", 0).ToString();
        }

        if (this.gameObject.tag == "HighScoreHard")
        {
            HighScoreHard.text = PlayerPrefs.GetInt("HighScoreHard", 0).ToString();
        }
    }

    private void highScore(string highScore, Text highScoreText)
    {
        if (this.gameObject.tag == highScore)
        {
            highScoreText.text = PlayerPrefs.GetInt(highScore, 0).ToString();
        }
    }
}
