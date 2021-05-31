using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float maxTime = 1;
    public float maxTime_1 = 0.5f;
    public GameObject coin;
    public GameManager gameManager = new GameManager();
    public float height;

    private float timer = 0.5f;
    private float timer_1 = 0;

    void Start()
    {
        maxTime = 9f;
        maxTime_1 = 0.5f;
    }

    void Update()
    {

        if (BirdBehaviour.IsGamePlaying == true)
        {
            if (timer_1 > maxTime_1)
            {
                GameObject newcoin = Instantiate(coin);
                newcoin.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newcoin, 15);
                timer_1 = -1;
            }
            if(timer_1 != -1)
            {
                timer_1 += Time.deltaTime;
            }
        }

        if (BirdBehaviour.IsGamePlaying == true)
        {
            if (timer > maxTime)
            {                
                GameObject newcoin = Instantiate(coin);
                newcoin.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newcoin, 15);
                timer = 0;
                
            }
            timer += Time.deltaTime;
        }
    }
}
