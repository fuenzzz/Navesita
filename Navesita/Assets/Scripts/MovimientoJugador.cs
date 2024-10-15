using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    private float movimienoFuerza = 10f;


    private Rigidbody2D miCuerporigido;



    // Start is called before the first frame update
    void Start()
    {
        miCuerporigido = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxisRaw("Horizontal"); //esta variable puede ser -1, 0 o 1
        Vector2 posicionJug = transform.position;

        posicionJug = posicionJug + new Vector2(movementX, 0F) * movimienoFuerza * Time.deltaTime;

        transform.position = posicionJug;


    }
}
