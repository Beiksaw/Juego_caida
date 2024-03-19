using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Derrota : MonoBehaviour
{
    public string nombreEscenaDestino; // El nombre de la escena a la que quieres ir

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Verifica si el jugador ha chocado con este objeto
        {
            // Carga la escena especificada
            SceneManager.LoadScene(nombreEscenaDestino);
        }
    }
}
