using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public float Downd;
    public float Up;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Weapon")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Player")
        {
            rb.velocity = new Vector2(Downd, Up);
        }
    }
}
