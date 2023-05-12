using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private float AttackCoaldown;
    private Animator Anim;
    private Move Player;
    private float CoaldownTimer = Mathf.Infinity;

    [SerializeField] private Transform FirePoint;
    [SerializeField] private GameObject[] Fire;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Player = GetComponent<Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) && CoaldownTimer > AttackCoaldown)
        {
            playerFire();
        }
        CoaldownTimer += Time.deltaTime;
    }

    private void playerFire()
    {
        Anim.SetTrigger("Fire");
        CoaldownTimer = 0;
        Fire[FireCek()].transform.position = FirePoint.position;
        Fire[FireCek()].GetComponent<FireScript>().SetDirection(Mathf.Sign(transform.localScale.x));

    }

    private int FireCek()
    {
        for(int i = 0; i < Fire.Length; i++)
        {
            if (!Fire[i].activeInHierarchy)
            {
                return i;
            }
        }
        return 0;
    }
}
