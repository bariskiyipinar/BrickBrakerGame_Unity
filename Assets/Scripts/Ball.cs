using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float ballSpeed;

    private Rigidbody2D rb;

    [SerializeField] private Transform ballStartPos;
    bool isplay;

    GameManager gameManager;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager=FindAnyObjectByType<GameManager>();
    }


    private void Update()
    {
        if (!isplay)
        {
            transform.position = ballStartPos.position;
        }

        if (Input.GetButtonDown("Jump") && !isplay)
        {
            isplay = true;
            rb.AddForce(Vector2.up* ballSpeed, ForceMode2D.Impulse);
        }



    }


    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.CompareTag("Bottom")){

            rb.velocity = Vector2.zero;

            gameManager.HealthBall(-1);
            isplay = false;

          
         
        }
    }

}
