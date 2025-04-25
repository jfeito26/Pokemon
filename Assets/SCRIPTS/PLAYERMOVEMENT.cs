using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PLAYERMOVEMENT : MonoBehaviour
{
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener la entrada de movimiento horizontal (izquierda/derecha) y vertical (arriba/abajo)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (Mathf.Abs(horizontal) > Mathf.Abs(vertical)) // Evitar el movimiento diagonal, solo se permite mover en una dirección a la vez
        {
            vertical = 0; // Desactivar el movimiento vertical si el horizontal es mayor
        }
        else
        {
            horizontal = 0; // Desactivar el movimiento horizontal si el vertical es mayor
        }

        // Mover al jugador
        Vector2 movement = new Vector2(horizontal, vertical);
        transform.Translate(movement * speed * Time.deltaTime); // Mover el jugador con la velocidad y el tiempo, y en la dirección especificada

    }
}
