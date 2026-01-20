using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List <Sprite> barrels;
    public int randomNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pickRandomColor();
        pickRandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("Try to change the sprite please");
            //pickRandomColor();
            if (barrels.Count > 0) 
            {
                pickRandomSprite();
            }

        }

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

        if(Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }

    void pickRandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
        //spriteRenderer.color = col;
    }
    void pickRandomSprite()
    {

        //pick a random number
        randomNum = Random.Range(0, barrels.Count);
        //use number to choose sprite
        //assign that sprite
        spriteRenderer.sprite = barrels[randomNum];
    }
}
