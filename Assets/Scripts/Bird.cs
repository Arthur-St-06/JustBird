using UnityEngine;

public class Bird : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("IsPointerDown", false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ScreenScript.isPointerDown)
        {
            anim.SetBool("IsPointerDown", true);
        }
    }
}
