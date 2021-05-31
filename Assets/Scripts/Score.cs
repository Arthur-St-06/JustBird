using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;
    public GameObject Text;

    private static int score10;
    private static int score20;
    private static int score50;

    private static int EasyBonusScore;
    private static int MediumBonusScore;
    private static int HardBonusScore;

    public Bird bird = new Bird();

    public float notPlayingScorePosition;

    public float PlayingScorePosition;

    void Awake()
    {
        Text.transform.position = new Vector2(transform.position.x, 5000);

        notPlayingScorePosition = Screen.height + 1500;
        PlayingScorePosition = Screen.height * 7 / 8;
    }

    void Start()
    {
        score = 0;
        if (this.gameObject.tag == "EasyScore")
        {
            score50 = PlayerPrefs.GetInt("HighScoreEasy", 0) / 50;
            score = score50 * 10;
            EasyBonusScore = score50 * 10;
        }
        else if (this.gameObject.tag == "MediumScore")
        {
            score20 = PlayerPrefs.GetInt("HighScoreMedium", 0) / 20;
            score = score20 * 10;
            MediumBonusScore = score20 * 10;
        }
        else
        {
            score10 = PlayerPrefs.GetInt("HighScoreHard", 0) / 10;
            score = score10 * 10;
            HardBonusScore = score10 * 10;
        }

        Text.transform.position = new Vector2(transform.position.x, 5000);
    }

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();

        if (BirdBehaviour.IsGamePlaying)
        {
            Text.transform.position = new Vector2(transform.position.x, PlayingScorePosition);
        }

        if (BirdBehaviour.IsGamePlaying == false)
        {
            Text.transform.position = new Vector2(transform.position.x, notPlayingScorePosition);
        }
    }

    public int ScoreGetter()
    {
        return score;
    }

    public int EasyBonus()
    {
        return EasyBonusScore;
    }

    public int MediumBonus()
    {
        return MediumBonusScore;
    }

    public int HardBonus()
    {
        return HardBonusScore;
    }
}