using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    static int score = 0;
    public static int lives = 3;
    static int tens = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //destroying the projectile and animals on collision
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Sandwich") {
            Destroy(gameObject);
            Destroy(other.gameObject);
            score++;
            Debug.Log("Score = " + score.ToString());
            while (score==tens) {
                lives++;
                Debug.Log("You gained a life! Current amount: " + lives.ToString());
                tens+=10;
            }
        }
        if (other.gameObject.tag == "Player") {
            lives--;
            Debug.Log("Lives = " + lives.ToString());
            if (lives <= 0) {
                Debug.Log("Game Over!");
            }
        }
    }
}
