using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Panel;
    void GameOver()
    {
        Panel.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        alien.Muerte += GameOver;
    }
    private void OnDisable()
    {
        alien.Muerte -= GameOver;
    }

}
