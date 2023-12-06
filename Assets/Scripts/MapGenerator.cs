using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public int width = 10; // Ancho del mapa en salas
    public int height = 10; // Altura del mapa en salas
    public GameObject roomPrefab; // Prefab de la sala
    public Material wallMaterial; // Material de los muros
    public Material floorMaterial; // Material del piso

    void Start()
    {
        GenerateMap();
    }

    void GenerateMap()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 position = new Vector3(x * 10, 0, y * 10); // Ajusta según el tamaño de tus salas
                GameObject room = Instantiate(roomPrefab, position, Quaternion.identity);

                // Aplica las texturas a los muros y pisos
                ApplyTextures(room);

                // Añade lógica adicional según sea necesario, como la conexión de salas
            }
        }
    }

    void ApplyTextures(GameObject room)
    {
        // Aplica el material de los muros
        Renderer[] wallRenderers = room.GetComponentsInChildren<Renderer>(true);
        foreach (Renderer wallRenderer in wallRenderers)
        {
            if (wallRenderer.CompareTag("Wall"))
            {
                wallRenderer.material = wallMaterial;
            }
        }

        // Aplica el material del piso
        Renderer[] floorRenderers = room.GetComponentsInChildren<Renderer>(true);
        foreach (Renderer floorRenderer in floorRenderers)
        {
            if (floorRenderer.CompareTag("Floor"))
            {
                floorRenderer.material = floorMaterial;
            }
        }
    }
}

