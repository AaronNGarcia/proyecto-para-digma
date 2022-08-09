using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja : MonoBehaviour
{
    public GameObject box;
    public GameObject gusano;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("alien"))
        {
            Destroy(box);
            gusano.SetActive(true);
        }
    }
}
