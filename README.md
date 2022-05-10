# proyecto-para-digma
juego del alien

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{

    public float velocidad;
    public float salto;
    private Rigidbody2D rb2d;
    public float Distancia_RayCast = 0.5f;
    public LayerMask suelo;
    public bool tocoElPiso;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(inputX,0);

        rb2d.transform.Translate(movimiento * velocidad * Time.deltaTime);
        if (Physics2D.Raycast(transform.position, Vector2.down, Distancia_RayCast, suelo))
        {
            tocoElPiso = true;
        }
        else
        {
            tocoElPiso = false;
        }

        if (Input.GetKey(KeyCode.Space)&& tocoElPiso)
        {
            rb2d.AddForce(Vector2.up * salto * Time.deltaTime, ForceMode2D.Impulse);
        }

                
    }
    private void OnDrawGizmoSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector2.down * Distancia_RayCast);
    }
}
