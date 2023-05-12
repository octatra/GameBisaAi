using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealtyBar : MonoBehaviour
{
    [SerializeField] private Healty playerHealty;
    [SerializeField] private Image totalHealty;
    [SerializeField] private Image currentHealty;

    // Start is called before the first frame update
    void Start()
    {
        totalHealty.fillAmount = playerHealty.CurrentHealty / 4;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealty.fillAmount = playerHealty.CurrentHealty / 4;
    }
}
