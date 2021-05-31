using System.Collections.Generic;
using UnityEngine;

public class BgSetup : MonoBehaviour
{
    private Score _score_ = new Score();
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("Night", false);
        anim.SetBool("Day", true);
    }

    void Update()
    {
        if (this.gameObject.tag == "bgSetupEasy")
        {
            List<int> scoreFifty = new List<int>();

            var quantity = _score_.ScoreGetter() / 50 >= 1;
            if (quantity)
            {
                int a = _score_.ScoreGetter() / 50;
                if (!scoreFifty.Contains(a))
                {
                    scoreFifty.Add(a);
                }
            }
            foreach (int i in scoreFifty)
            {
                if (i % 2 != 0)
                {

                    anim.SetBool("Night", true);
                    anim.SetBool("Day", false);
                }
                else
                {
                    anim.SetBool("Night", false);
                    anim.SetBool("Day", true);

                }
            }
        }

        if (this.gameObject.tag == "bgSetupMedium")
        {
            List<int> scoreFifty = new List<int>();

            var quantity = _score_.ScoreGetter() / 20 >= 1;
            if (quantity)
            {
                int a = _score_.ScoreGetter() / 20;
                if (!scoreFifty.Contains(a))
                {
                    scoreFifty.Add(a);
                }
            }
            foreach (int i in scoreFifty)
            {
                if (i % 2 != 0)
                {

                    anim.SetBool("Night", true);
                    anim.SetBool("Day", false);
                }
                else
                {
                    anim.SetBool("Night", false);
                    anim.SetBool("Day", true);

                }
            }
        }

        if (this.gameObject.tag == "bgSetupHard")
        {
            List<int> scoreFifty = new List<int>();

            var quantity = _score_.ScoreGetter() / 10 >= 1;
            if (quantity)
            {
                int a = _score_.ScoreGetter() / 10;
                if (!scoreFifty.Contains(a))
                {
                    scoreFifty.Add(a);
                }
            }
            foreach (int i in scoreFifty)
            {
                if (i % 2 != 0)
                {

                    anim.SetBool("Night", true);
                    anim.SetBool("Day", false);
                }
                else
                {
                    anim.SetBool("Night", false);
                    anim.SetBool("Day", true);

                }
            }
        }

    }
}