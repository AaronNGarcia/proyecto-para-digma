using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien : MonoBehaviour
{
    public float velocidad;
    public float salto;
    private Rigidbody2D rb2d;
    public float Distancia_RayCast = 0.7f;
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

        Vector2 movimiento = new Vector2(inputX, 0);

        rb2d.transform.Translate(movimiento * velocidad * Time.deltaTime);

        if (Physics2D.Raycast(transform.position, Vector2.down, Distancia_RayCast, suelo))
        {
            tocoElPiso = true;
        }
        else
        {
            tocoElPiso = false;
        }

        if (Input.GetKey(KeyCode.Space) && tocoElPiso)
        {
            rb2d.AddForce(Vector2.up * salto * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (inputX < -0.1f)
        {
            transform.localScale = new Vector3(-1, 1f, 1f);
        }
        if (inputX > 0.1f)
        {
            transform.localScale = new Vector3(1, 1f, 1f);
        }

    }
    private void OnDrawGizmoSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector2.down * Distancia_RayCast);
    }
}
