using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arena : MonoBehaviour
{
    public GameObject bar;
    public GameObject puerta;
    public GameObject barricada;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("alien"))
        {
            bar.SetActive(true);
            puerta.SetActive(true);
            barricada.SetActive(true);
            
        }
    }
}
