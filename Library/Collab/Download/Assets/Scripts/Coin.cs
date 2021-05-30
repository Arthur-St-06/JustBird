using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public static bool moveScore;
    public Animation anim;
    public Text text_label;

    private Vector3 text_pos;

    void Start()
    {
        moveScore = false;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        moveScore = true;
        Vector3 text_pos = Camera.main.WorldToScreenPoint(transform.position);
        text_label.transform.position = text_pos;
        if (PlayerPrefs.GetString("Music") != "no")
        {
            GameObject.Find("CoinPickupSound").GetComponent<AudioSource>().Play();
        }

        Score.score += 2;
        Destroy(gameObject);
    }
}
