using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTunel : MonoBehaviour
{
    public GameObject prefabSegmento;
    public int cantidadSegmentos = 12;
    public float distanciaEntreSegmentos = 5f;
    public bool usarColores = true;
    public bool usarLuces = true;
    public bool usarRotacion = true;

    void Start()
    {
        for (int i = 0; i < cantidadSegmentos; i++)
        {
            // Posición centrada sobre el eje Z
            Vector3 posicion = new Vector3(0f, 0f, i * distanciaEntreSegmentos);
            GameObject nuevoSegmento = Instantiate(prefabSegmento, posicion, Quaternion.identity, transform);
            
            // Alineamos correctamente: sin rotación ni escala errónea
            nuevoSegmento.transform.localRotation = Quaternion.identity;
            nuevoSegmento.transform.localScale = Vector3.one;

            // Color dinámico
            if (usarColores)
            {
                Color color = Color.HSVToRGB((float)i / cantidadSegmentos, 0.8f, 1f);
                Renderer rend = nuevoSegmento.GetComponent<Renderer>();
                if (rend != null) rend.material.color = color;
            }

            // Luz en el centro del cuadro
            if (usarLuces)
            {
                Light luz = nuevoSegmento.AddComponent<Light>();
                luz.type = LightType.Point;
                luz.range = 10;
                luz.intensity = 2;
                luz.color = Color.HSVToRGB((float)i / cantidadSegmentos, 1f, 1f);
            }
        }
    }
}
