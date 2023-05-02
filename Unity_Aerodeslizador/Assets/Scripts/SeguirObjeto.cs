using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirObjeto : MonoBehaviour
{
    public Transform objetoASeguir;  // Objeto a seguir
    public float distancia = 10.0f; // Distancia de la c�mara al objeto
    public float altura = 5.0f;     // Altura de la c�mara respecto al objeto

    void LateUpdate()
    {
        // Obtener la posici�n del objeto a seguir
        Vector3 posicionObjeto = objetoASeguir.position;

        // Calcular la nueva posici�n de la c�mara
        Vector3 nuevaPosicion = new Vector3(posicionObjeto.x, posicionObjeto.y + altura, posicionObjeto.z - distancia);

        // Actualizar la posici�n de la c�mara
        transform.position = nuevaPosicion;

        // Hacer que la c�mara mire al objeto a seguir
        transform.LookAt(objetoASeguir);
    }
}







