using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPuertas : MonoBehaviour
{
    public GameObject camaraA1, camaraB1;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            camaraA1.SetActive(false);
            camaraB1.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.tag == "Player")
            {
                camaraA1.SetActive(true);
                camaraB1.SetActive(false);

            }

        }
    }
}
