using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    [SerializeField] private float Speed;
    private float direction;
    private bool hit;
    private BoxCollider2D boxColider;
    private float Project_livetime;

    public GameObject Weapons;
    // Start is called before the first frame update

    void Awake()
    {
        boxColider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hit) return;

        float moveSpeed = Speed * Time.deltaTime * direction;
        transform.Translate(moveSpeed, 0, 0);
        Project_livetime += Time.deltaTime;
        if (Project_livetime > 1) gameObject.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        hit = false;
        boxColider.enabled = true;
        Weapons.SetActive(false);
    }

    public void SetDirection(float project_direction)
    {
        Project_livetime = 0;
        direction = project_direction;
        gameObject.SetActive(true);
        hit = false;
        boxColider.enabled = true;

        float localScaleX = transform.localScale.x;
        if(Mathf.Sign(localScaleX) != project_direction)
        {
            localScaleX = -localScaleX;
        }
        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }

    private void Diactive()
    {
        gameObject.SetActive(false);
    }
}
