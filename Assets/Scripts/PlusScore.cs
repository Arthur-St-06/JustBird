using UnityEngine;
using UnityEngine.UI;

public class PlusScore : MonoBehaviour
{
    public Text PlusScoreText;
    public float timer = 0;
    public float maxTime = 1;

    void Update()
    {
        if (GameManager._GameOver_)
        {
            Destroy(gameObject);
        }

        if (timer > maxTime)
        {
            PlusScoreText = GetComponent<Text>();
            var tempColor = PlusScoreText.color;
            tempColor.a = 0f;
            PlusScoreText.color = tempColor;
        }
        else
        {
            PlusScoreText = GetComponent<Text>();
            var tempColor = PlusScoreText.color;
            tempColor.a = 255f;
            PlusScoreText.color = tempColor;
        }
        timer += Time.deltaTime;
    }
}