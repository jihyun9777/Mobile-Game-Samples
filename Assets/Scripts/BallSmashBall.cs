using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSmashBall : MonoBehaviour
{
    private void OnMouseDown() 
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().SmashScoreUp();

        Destroy(gameObject);
    }
}
