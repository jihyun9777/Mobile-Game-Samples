using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;

    private void Awake() 
    {
        //Access to Rigidbody 2D attached to the paddle
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() 
    {
        TouchMove();    
    }

    void TouchMove()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(touchPos.x < 0)
            {
                //move left
                rb.velocity = Vector2.left * moveSpeed;
            }
            else
            {
                //move right
                rb.velocity = Vector2.right * moveSpeed;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
