using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float maxTime = 1;
    public float maxTime_1 = 0.5f;
    private float timer = 0.5f;
    private float timer_1 = 0;
    public GameObject coin;

    public GameManager gameManager = new GameManager();

    public float height;

    void Start()
    {
        maxTime = 3f;

        maxTime_1 = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {

        if (rb_sc.GamePlaying == true)
        {
            if (timer_1 > maxTime_1)
            {
                    GameObject newpipe = Instantiate(coin);
                    newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                    Destroy(newpipe, 15);
                    timer_1 = -1;
            }
            if(timer_1 != -1)
            {
                timer_1 += Time.deltaTime;
            }
        }

        if (rb_sc.GamePlaying == true)
        {
                if (timer > maxTime)
            {                
                    GameObject newpipe = Instantiate(coin);
                    newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                    Destroy(newpipe, 15);
                    timer = 0;
                
            }
            timer += Time.deltaTime;
        }
    }
}
