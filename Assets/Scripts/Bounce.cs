using UnityEngine;

public class Bounce : MonoBehaviour
{
    float bounce = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newBouncePos = transform.position;
        newBouncePos.y += bounce;
        transform.position = newBouncePos;

        if(newBouncePos.y > -3.50)
        {
            bounce = bounce * -1;
        }
        else if(newBouncePos.y < -4.48)
        {
            bounce = bounce * -1;
        }
    }
}
