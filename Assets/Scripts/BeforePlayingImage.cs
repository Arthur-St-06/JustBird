using UnityEngine;

public class BeforePlayingImage : MonoBehaviour
{
    public GameObject startImage;

    void Start()
    {
        startImage.SetActive(true);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ScreenScript.isPointerDown)
        {
            startImage.SetActive(false);
        }
    }
}
