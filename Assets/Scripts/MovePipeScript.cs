using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipeScript : MonoBehaviour
{
    public float speed;

    void Update()
    {
        if (BirdBehaviour.IsGamePlaying == true)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
