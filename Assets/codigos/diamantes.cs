using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamantes : MonoBehaviour
{
    private GameObject efecto;
    private float cantidadPuntos;
    private Puntaje puntaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puntaje.SumarPuntos(cantidadPuntos);
            instantiate(efecto, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
