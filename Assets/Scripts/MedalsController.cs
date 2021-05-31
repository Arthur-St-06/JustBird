using UnityEngine;

public class MedalsController : MonoBehaviour
{
    public Score Score;
    public GameObject silverMedal;
    public GameObject GoldMedal;

    void Start()
    {
        if (this.gameObject.tag == "EasyMedalsController")
        {
            medalsController(50, 100);
        }

        else if (this.gameObject.tag == "MedumMedalsController")
        {
            medalsController(20, 40);
        }
        else
        {
            medalsController(10, 20);
        }
    }

    private void medalsController(int lowScore, int highScore)
    {
        if (Score.ScoreGetter() > lowScore && Score.ScoreGetter() <= highScore)
        {
            silverMedal.SetActive(true);
        }
        else if (Score.ScoreGetter() > highScore)
        {
            silverMedal.SetActive(false);
            GoldMedal.SetActive(true);
        }
    }
}
