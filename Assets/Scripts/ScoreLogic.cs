using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    public Score Score;
    public Text score;
    public Text highScore;

    private int number;

    void Update()
    {
        if (this.gameObject.tag == "EasyScoreLogic")
        {
            scoreLogic("HighScoreEasy");
        }

        if (this.gameObject.tag == "MediumScoreLogic")
        {
            scoreLogic("HighScoreMedium");
        }

        if (this.gameObject.tag == "HardScoreLogic")
        {
            scoreLogic("HighScoreHard");
        }
        if (this.gameObject.tag == "$$$ScoreLogic")
        {
            scoreLogic("$$$ScoreLogic");
        }
    }

    private void scoreLogic(string HighScore)
    {
        highScore.text = PlayerPrefs.GetInt(HighScore, 0).ToString();

        number = Score.ScoreGetter();
        score.text = number.ToString();

        if (number > PlayerPrefs.GetInt(HighScore, 0))
        {
            PlayerPrefs.SetInt(HighScore, number);
            highScore.text = number.ToString();
        }
    }
}
