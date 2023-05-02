using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista : MonoBehaviour
{
    public float alturaMaxima = 5.0f;
    public float distanciaSuelo = 0.5f;

    private void OnCollisionStay(Collision collision)
    {
        // Solo detectar colisiones con los lados de la pista
        if (collision.gameObject.CompareTag("Lateral"))
        {
            // Obtener la posición del objeto colisionado
            Vector3 posicionObjeto = collision.transform.position;

            // Lanzar un raycast hacia abajo para determinar la altura del objeto
            RaycastHit hit;
            if (Physics.Raycast(posicionObjeto + Vector3.up * alturaMaxima, Vector3.down, out hit))
            {
                // Si el objeto está a una distancia menor a distanciaSuelo, ajustar su posición
                float distancia = alturaMaxima - hit.distance;
                if (distancia > 0 && distancia < distanciaSuelo)
                {
                    collision.transform.position += Vector3.up * distancia;
                }
            }
        }
    }
}