using UnityEngine;

public class SlightMovement : MonoBehaviour
{

	public float speed;
	public float x1;
	public float x2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Sets up the movement
		Vector2 newPos = transform.position;
		newPos.x += speed;
		transform.position = newPos;


		//Restrains the movement so it's not moving on one direction all the time
		if (newPos.x < x1 || newPos.x > x2)
		{
			speed = speed * -1;
		}
	}
}
