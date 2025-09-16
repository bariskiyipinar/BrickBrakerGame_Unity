using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed;

    public static bool ismoving;

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {

        PaddleMoving();
    }


    void PaddleMoving()
    {
        float h = Input.GetAxis("Horizontal") * speed;


      
        rb.velocity=new Vector2(h,rb.velocity.y);

        float ClampX = Mathf.Clamp(transform.position.x, -7.5f, 7.5f);

        transform.position = new Vector2(ClampX, transform.position.y);
    }
}
