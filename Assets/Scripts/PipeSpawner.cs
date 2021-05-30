using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    public float maxTime_1 = 0;
    public GameObject pipe;
    public GameManager gameManager = new GameManager();
    public float height;

    private float timer = 0;
    private float timer_1 = 0;

    void Update()
    {

        if (BirdBehaviour.IsGamePlaying == true)
        {
            if (timer_1 == maxTime_1)
            {
                GameObject newpipe = Instantiate(pipe);
                newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newpipe, 15);
                timer_1 = 1;
            }
        }

        if (BirdBehaviour.IsGamePlaying == true)
        {
            if (timer > maxTime)
            {                
                GameObject newpipe = Instantiate(pipe);
                newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                Destroy(newpipe, 15);
                timer = 0;
            }
            timer += Time.deltaTime;
        }
    }
}
