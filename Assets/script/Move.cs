using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    public float move_speed;
    public float JumpM;
    private bool Grounded;

//    Baru
    private Animator Anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Grounded = false;

  //    Baru
        Anim = GetComponent<Animator>();
    }

    void Update()
    {
        float Horiz = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Horiz * move_speed, rb.velocity.y);

//        Player Flip
        if(Horiz > 0.01f)
        {
            transform.localScale = Vector3.one; //Vector3(1, 1, 1)
        }
        else if(Horiz < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

//        Player Jump
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpM);
            Grounded = false;
        }
/*        Baru*/
        Anim.SetBool("Run", Horiz != 0);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground")
        {
            Grounded = true;
            Debug.Log("Hello World");
        }        
    }
}
