using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 mousePos;
    public GameObject BrainBlast;
    public Transform BrainTransform;
    public bool PuedeTirar;
    private float temporizador;
    public float TiempoEntreTiros;

    // Start is called before the first frame update
    
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float RotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, RotZ);

        if (!PuedeTirar)
        {
            temporizador += Time.deltaTime;
            if (temporizador > TiempoEntreTiros)
            {
                PuedeTirar = true;
                temporizador = 0;
            }
        }

        if (Input.GetMouseButton(0) && PuedeTirar)
        {
            PuedeTirar = false;
            Instantiate(BrainBlast, BrainTransform.position, Quaternion.identity);
        }

    }
}
