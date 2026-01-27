using UnityEngine;
using UnityEngine.InputSystem;

public class CursorFolloqOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Vector2 posX = 
		//transform.position = mousePos;
        //if(mousePos.x <= -0.71 || mousePos.x >= 0.41 && mousePos.y <= 0.4 || mousePos.y >= -0.04)
        //{
            //transform.position.x = -0.421f;
            //transform.position.y = 0.069f;
        //}
	}
}
