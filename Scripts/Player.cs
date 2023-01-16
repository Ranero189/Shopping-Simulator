using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 4f;

    Rigidbody2D rb;
    Animator anim;
    float moveX;
    float moveY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveX * moveSpeed, moveY * moveSpeed);

        if (moveX != 0 || moveY != 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }

    void LateUpdate()
    {
        if (moveX < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (moveX > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    public void setSkin()
    {
        anim.SetBool("Player2", false);
        anim.SetBool("Player1", true);
    }
    public void setSkin1()
    {
        anim.SetBool("Player1", false);
        anim.SetBool("Player2", true);
    }
}