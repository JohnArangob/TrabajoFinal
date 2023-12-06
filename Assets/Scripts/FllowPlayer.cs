using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;  // Asigna el objeto del personaje desde el Inspector
    public float distanciaLejana = 10f;  // A�ade la variable distanciaLejana aqu�

    void LateUpdate()
    {
        if (player != null)
        {
            // Ajusta la posici�n y rotaci�n de la c�mara para seguir al personaje
            transform.position = player.position - player.forward * distanciaLejana * velocidadSeguimiento;

            transform.LookAt(player.position);
        }
    }
}
