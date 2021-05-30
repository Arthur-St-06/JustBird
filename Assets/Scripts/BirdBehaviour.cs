using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdBehaviour : MonoBehaviour
{
    public static bool IsGamePlaying;
    public float JumpForce = 1.85f;
    private Rigidbody2D birdRigidbody;
    private GameManager GameManager = new GameManager();

    private void Start()
    {
        IsGamePlaying = false;

        birdRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (IsGamePlaying == false)
        {
            birdRigidbody.gravityScale = 0f;
        }

        if (IsGamePlaying)
        {
            birdRigidbody.gravityScale = 0.75f;
        }

        if (Input.GetMouseButtonDown(0) && GameManager._GameOver_ == false && ScreenScript.isPointerDown)
        {
            Jump();
        }

        //turn bird according to velocity
        transform.eulerAngles = new Vector3(0, 0, birdRigidbody.velocity.y * 20);
    }

    private void Jump()
    {
        birdRigidbody.velocity = Vector2.up * JumpForce;
        IsGamePlaying = true;
        GameManager.PlayMusicWhenIconisOn("ClickToJumpAudio");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pipe"))
        {
            GameManager.PlayMusicWhenIconisOn("DieSound");
            GameManager._GameOver_ = true;
            IsGamePlaying = false;

            GameManager.GameOver();
        }
    }
}