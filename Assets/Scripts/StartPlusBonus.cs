using UnityEngine;
using UnityEngine.UI;

public class StartPlusBonus : MonoBehaviour
{
    public Text ScoreText;
    private Score score = new Score();

    void Update()
    {
        if (this.gameObject.tag == "EasyScoreBonus")
        {
            ScoreText.text = score.EasyBonus().ToString();
        }

        else if (this.gameObject.tag == "MediumScoreBonus")
        {
            ScoreText.text = score.MediumBonus().ToString();
        }

        else
        {
            ScoreText.text = score.HardBonus().ToString();
        }
    }
}