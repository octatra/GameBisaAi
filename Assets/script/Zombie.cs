using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float ZombieSpeed;

    [HideInInspector]
    public bool Patrol;
    private bool TurnFlip;

    public Rigidbody2D rb;
    public Transform GroundCek;
    public LayerMask GroundLayer;
    public Collider2D ColiderZombie;

    // Start is called before the first frame update
    void Start()
    {
        Patrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Patrol)
        {
            Patroli();
        }
    }
    private void FixedUpdate()
    {
        if (Patrol)
        {
            TurnFlip = !Physics2D.OverlapCircle(GroundCek.position, 0.1f, GroundLayer);
        }
    }
    void Patroli()
    {
        if (TurnFlip || ColiderZombie.IsTouchingLayers(GroundLayer))
        {
            Flip();
        }
        rb.velocity = new Vector2(ZombieSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void Flip()
    {
        Patrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        ZombieSpeed *= -1;
        Patrol = true;
    }
}
