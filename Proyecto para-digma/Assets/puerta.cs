using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class puerta : MonoBehaviour
{
    public int HP;
    private float timeBtwDamage;

    public Animator salto;
    public Slider HPbar;

    public GameObject bomba;
    public GameObject bar;

    void Update()
    {
        HPbar.value = HP;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            HP=HP-1;
            if (HP < 0)
            {
                Destroy(this.gameObject);
                bomba.SetActive(true);
                bar.SetActive(false);
            }
        }
    }
}
