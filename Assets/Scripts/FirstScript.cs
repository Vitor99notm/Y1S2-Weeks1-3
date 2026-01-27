using UnityEngine;

public class FirstScript : MonoBehaviour
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
        newPos.x += speed;
        transform.position = newPos;


        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < 0 || screenPosition.x > Screen.width)
        {
            speed = speed * -1;
        }
    }
}
