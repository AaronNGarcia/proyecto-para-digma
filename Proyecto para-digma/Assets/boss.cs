using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{

    public GameObject barricada;
    public GameObject bomba;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bomba"))
        {
            Destroy(barricada);
            Destroy(bomba);
        }
    }
}
