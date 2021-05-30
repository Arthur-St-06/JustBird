using UnityEngine;

public class AddScore : MonoBehaviour
{
    //If bird  enters pipe score will be increased by 1
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }
}
