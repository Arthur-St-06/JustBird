using UnityEngine;
using UnityEngine.UI;

public class DieScore : MonoBehaviour
{
    public Text dieScore;

    void Start()
    {
        dieScore.text = Score.score.ToString();
    }
}
