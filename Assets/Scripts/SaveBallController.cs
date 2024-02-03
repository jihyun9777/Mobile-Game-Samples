using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveBallController : MonoBehaviour
{
    Rigidbody2D rb;
    public float bounceForce;
    bool gameStarted;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if(!gameStarted)
        {
            if(Input.anyKeyDown)
            {
                StartBounce();
                gameStarted = true;
                GameManager.instance.GameStart();
            }
        }
        
    }

    void StartBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);

        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "FallCheck")
        {
            GameManager.instance.Restart();

            //or SceneManager.LoadScene("SaveBall");
        }
        else if(collision.gameObject.tag == "Paddle")
        {
            GameManager.instance.ScoreUp();
        }
    }
}
