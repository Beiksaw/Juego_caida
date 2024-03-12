using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del personaje

    void Update()
    {
        // Obtener la entrada del eje horizontal y vertical
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular la dirección de movimiento basada en la entrada del jugador
        Vector3 direccionMovimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical).normalized;

        // Mover el personaje en la dirección calculada en relación con su orientación
        transform.Translate(direccionMovimiento * velocidad * Time.deltaTime, Space.Self);
    }
}


