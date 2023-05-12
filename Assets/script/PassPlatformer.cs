using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassPlatformer : MonoBehaviour
{
    private Collider2D _colider;
    private bool _playerOnPlatform;
    void Start()
    {
        _colider = GetComponent<Collider2D>();
    }
    void Update()
    {
        if(_playerOnPlatform && Input.GetAxisRaw("Vertical") < 0)
        {
            _colider.enabled = false;
            StartCoroutine(EnabledColider());
        }
    }

    private IEnumerator EnabledColider()
    {
        yield return new WaitForSeconds(0.5f);
        _colider.enabled = true;
    }

    private void SetPlayerOnPlatform(Collision2D other, bool value)
    {
        var player = other.gameObject.GetComponent<Move>();
        if(player != null)
        {
            _playerOnPlatform = value;
        }
    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        SetPlayerOnPlatform(other, true);
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        SetPlayerOnPlatform(other, true);
    }

}
