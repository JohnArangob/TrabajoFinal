using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;  // Asigna el objeto del personaje desde el Inspector
    public float distanciaLejana = 10f;  // Añade la variable distanciaLejana aquí

    void LateUpdate()
    {
        if (player != null)
        {
            // Ajusta la posición y rotación de la cámara para seguir al personaje
            transform.position = player.position - player.forward * distanciaLejana * velocidadSeguimiento;

            transform.LookAt(player.position);
        }
    }
}
