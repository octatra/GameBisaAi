using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gulungan : MonoBehaviour
{
    public GameObject WinPanel;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Destroy(gameObject);
            WinPanel.SetActive(true);
        }
    }
}
