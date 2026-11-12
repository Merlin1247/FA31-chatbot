using UnityEngine;
using UnityEngine.InputSystem;

public class sciptanimation : MonoBehaviour
{
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            animator.SetBool("someone", true);
        }
        if (!Keyboard.current.wKey.isPressed)
        {
            animator.SetBool("someone", false);
        }
    }
}
