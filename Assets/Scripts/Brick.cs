using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    GameManager gameManager;

    private void Start()
    {
        gameManager=FindAnyObjectByType<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {

            gameManager.UpdateScoreBall(5);
            Destroy(this.gameObject);
        }
    }
}
