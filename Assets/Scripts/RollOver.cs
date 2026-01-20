using UnityEngine;
using UnityEngine.InputSystem;

public class RollOver : MonoBehaviour
{
    public bool mouseIsOverMe = false;
    public RotateMe rotateMe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        float distance = Vector2.Distance(transform.position, mousePos);
        if(distance < 1)
        {
            mouseIsOverMe = true;
            rotateMe.speed = 100;
        }
        else
        {
            mouseIsOverMe = false;
            rotateMe.speed = 0;
        }
    }
}
