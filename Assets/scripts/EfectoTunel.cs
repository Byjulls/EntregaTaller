using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoTunel : MonoBehaviour
{
    public float velocidad = 2f;
    public float limiteZ = -10f;     // Cuando llegue a este punto, se reinicia
    public float distanciaTunel = 30f; // Cuánto mide el túnel (ajústalo si son muchos planos)

    void Update()
    {
        transform.Translate(Vector3.back * velocidad * Time.deltaTime);

        if (transform.position.z < limiteZ)
        {
            // Mueve el objeto al fondo del túnel para reiniciar
            transform.position = new Vector3(0f, transform.position.y, transform.position.z + distanciaTunel);
        }
    }
}
