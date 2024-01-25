using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class BalloonController : MonoBehaviour
{
    public float speed;
    AudioSource audioSource;
    
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 5.5f)
        {
            SceneManager.LoadScene("BalloonPop");
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, speed, 0);
    }

    private void OnMouseDown()
    {
        FindObjectOfType<BalloonScore>().IncrementScore();

        audioSource.Play();

        ResetPosition();
    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-2.5f, 2.5f);

        transform.position = new Vector2(randomX, -6f);
    }
}
