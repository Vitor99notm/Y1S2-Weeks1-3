using UnityEngine;
using UnityEngine.InputSystem;

public class MovementLR : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            newPos.x += speed * Time.deltaTime;
            transform.position = newPos;
        }
    }
}
