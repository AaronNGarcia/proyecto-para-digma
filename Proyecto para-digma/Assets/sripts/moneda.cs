using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class moneda : MonoBehaviour
{
    public delegate void MonedaEvent();
    public static MonedaEvent monedaEvent;
    // public static event Action monedaEvent;  // con Encapsulamiento
    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("alien"))
        {
            monedaEvent?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
