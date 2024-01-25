using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DodgePlayer : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb; 

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            //Where user is touching on a screen
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //Move left
            if(touchPos.x < 0)
            {
                rb.AddForce(Vector2.left * moveSpeed);
            }
            //Move right
            else
            {
                rb.AddForce(Vector2.right * moveSpeed);
            }

        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Block")
        {
            SceneManager.LoadScene("BlockDodge");
        }
    }
}
