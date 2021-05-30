using UnityEngine;
using UnityEngine.UI;

public class Ui_Setup : MonoBehaviour
{
    public Image fullScreenButton;

    void Update()
    {
        Camera cam = Camera.main;
        fullScreenButton.rectTransform.sizeDelta = new Vector2(cam.aspect * 1080, cam.orthographicSize * 854.5f);
    }
}
