using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float leftrightBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroying the projectile when it's above players view
        //destroying animal when they are under players view and printing "Game Over" message in console
        
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) {
            DetectCollisions.lives--;
            Destroy(gameObject);
        }
        else if (transform.position.x < -leftrightBound) {
            DetectCollisions.lives--;
            Destroy(gameObject);
        }
        else if (transform.position.x > leftrightBound) {
            DetectCollisions.lives--;
            Destroy(gameObject);
        }
    }
}
