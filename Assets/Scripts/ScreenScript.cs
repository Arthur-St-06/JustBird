using UnityEngine;

public class ScreenScript : MonoBehaviour
{
    public static bool isPointerDown;

    void Start()
    {
        isPointerDown = false;
    }

    public void IsPointerDown()
    {
        isPointerDown = true;
    }

    public void IsPointerUp()
    {
        isPointerDown = false;
    }

    public bool _IsPointerDown_()
    {
        return isPointerDown;
    }
}
