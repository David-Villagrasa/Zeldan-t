using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento

    

    void Update()
    {
        // Obtener las entradas del jugador (ejes horizontal y vertical)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Crear un Vector2 para almacenar la dirección del movimiento
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Obtener el componente Rigidbody2D del objeto
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Aplicar la velocidad al Rigidbody2D para mover el objeto
        rb.velocity = movement * speed;
    }

}
