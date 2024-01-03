using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BalloonController : MonoBehaviour
{
    public float speed;
    int score = 0;
    AudioSource audioSource;
    public TextMeshProUGUI scoreText;
    
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 5.5f)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, speed, 0);
    }

    private void OnMouseDown()
    {
        score ++;
        scoreText.text = score.ToString();

        audioSource.Play();

        ResetPosition();
    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-2.5f, 2.5f);

        transform.position = new Vector2(randomX, -6f);
    }
}
