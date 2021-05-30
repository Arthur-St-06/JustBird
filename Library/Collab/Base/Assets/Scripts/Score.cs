using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;

    public GameObject Text;

    public Bird bird = new Bird();

    public float notPlayingScorePosition;

    public float PlayingScorePosition;

    public float a;
    public float b;

    void Awake()
    {
        Camera cam = Camera.main;

        Text.transform.position = new Vector2(transform.position.x, 5000);

        notPlayingScorePosition = Screen.height + 1500;
        PlayingScorePosition = Screen.height - Screen.height / 8;
    }

    // Start is called before the first frame update
    void Start()
    {
        
              score = 0;
        Text.transform.position = new Vector2(transform.position.x, 5000);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();

        if (rb_sc.GamePlaying)
        {

            Text.transform.position = new Vector2(transform.position.x, PlayingScorePosition);
        }

        if (rb_sc.GamePlaying == false)
        {
            Text.transform.position = new Vector2(transform.position.x, notPlayingScorePosition);
        }

    }


    public int ScoreGetter()
    {
        return score;
    }

}
