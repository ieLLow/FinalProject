using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpHeight;
    public bool isJumping = false;
    public bool hitting = false;

    Animator anim;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        Hit();
    }

    void Move()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;
    }

    /*void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpHeight);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
            isJumping = false;
    }*/

    void Hit()
    {
        if(Input.GetKey(KeyCode.Z) && !hitting)
        {
            hitting = true;
            anim.SetBool("Hitting", hitting);
            return;
        }
    }
}
