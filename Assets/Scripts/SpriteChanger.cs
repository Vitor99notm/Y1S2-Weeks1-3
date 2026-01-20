using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pickRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame)
        //{
        //    pickRandomColor();
        //}

        //Get mouse position, is it over the shape? Yes: use color variable, No: set color white.
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousePos))
        {
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }

    void pickRandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
        //spriteRenderer.color = col;
    }
}
