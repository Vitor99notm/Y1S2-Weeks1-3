using UnityEngine;

public class RandomPos : MonoBehaviour
{
    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 randomPos = transform.position;
        
        t += Time.deltaTime;
        if ( t > 3)
        {
            randomPos.x = Random.Range(-9, 9);
            randomPos.y = Random.Range(-4, 4);
            transform.position = randomPos;
            t = 0;
        }
    }
}
