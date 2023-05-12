using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField] private Transform Player;

    [SerializeField] private float Cameraspeed;
    [SerializeField] private float disfaceAhead;
    private float lookAhead;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Player.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.position.x + lookAhead, transform.position.y, transform.position.z);

        lookAhead = Mathf.Lerp(lookAhead, (disfaceAhead * Player.localScale.x), Time.deltaTime * Cameraspeed);
    }
}
