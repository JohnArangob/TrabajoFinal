using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDoor : MonoBehaviour
{
    public int Scenes;
    public GameObject texto;
    private bool lugar;

    private void Awake()
    {
        texto.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && lugar== true){

            SceneManager.LoadScene(Scenes);
        }
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            texto.SetActive(true);
            lugar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            texto.SetActive(false);
            lugar = false;

        }
    }
}
