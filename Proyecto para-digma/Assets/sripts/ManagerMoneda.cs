using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerMoneda : MonoBehaviour
{
    public Text Monedatext;
    private int Contador;

    void MonedaText()
    {
        Contador++;
        Monedatext.text = "Monedas: " + Contador;
    }

    private void OnEnable()
    {
        moneda.monedaEvent += MonedaText;
    }

    private void OnDisable()
    {
        moneda.monedaEvent -= MonedaText;
    }
}
