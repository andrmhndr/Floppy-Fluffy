using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class player : MonoBehaviour
{
    public bool isPaused = false;
    public bool isOver = false;

    private Rigidbody2D rb;

    //jump 
    public float jumpPower = 0;

    //score
    public int score;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnJump()
    {
        if(!isPaused)
        {
            rb.AddForce(new Vector2(0f, jumpPower));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            score++;
        }

        if(collision.gameObject.tag == "barier")
        {
            isOver = true;
        }
    }
}
