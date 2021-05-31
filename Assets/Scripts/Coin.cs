using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text text_label;
    public PlusScore _plusScore_;

    private GameManager GameManager = new GameManager();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _plusScore_.timer = 0;
        Vector3 text_pos = Camera.main.WorldToScreenPoint(transform.position);
        text_label.transform.position = text_pos;

        GameManager.PlayMusicWhenIconisOn("CoinPickupSound");

        Score.score += 2;
        Destroy(gameObject);
    }
}