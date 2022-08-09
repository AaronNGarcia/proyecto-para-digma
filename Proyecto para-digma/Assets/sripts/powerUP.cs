using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUP : MonoBehaviour
{
 public GameObject brainBlast;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("alien"))
        {
            brainBlast.SetActive(true); ;
            Destroy(this.gameObject);
        }
    }
}
