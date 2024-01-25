using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitPlayer : MonoBehaviour
{
    public FixedJoystick joystick;
    public float moveSpeed;
    float hInput, vInput;
    int score = 0;
    public GameObject winText;
    public int winScore;

    private void FixedUpdate() 
    {
        hInput = joystick.Horizontal * moveSpeed;
        vInput = joystick.Vertical * moveSpeed;

        transform.Translate(hInput, vInput, 0);   
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Carrot")
        {
            score ++;
            Destroy(collision.gameObject);

            if(score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }
}
