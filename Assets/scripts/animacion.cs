using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    public Vector3 velocidadRotacion = new Vector3(0f, 100f, 0f); // Puedes cambiar esto para rotar en otros ejes

    void Update()
    {
        transform.Rotate(velocidadRotacion * Time.deltaTime);
    }
}
