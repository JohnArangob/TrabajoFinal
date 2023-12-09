using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField]
    int width = 10; // Ancho del mapa en salas

    [SerializeField]
    int height = 10; // Altura del mapa en salas

    [SerializeField]
    GameObject roomPrefab; // Prefab de la sala

    [SerializeField]
    Material wallMaterial; // Material de los muros

    [SerializeField]
    Material floorMaterial; // Material del piso

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
                Vector3 position = new(x * 10, 0, y * 10); // Ajusta seg�n el tama�o de tus salas
                GameObject room = Instantiate(roomPrefab, position, Quaternion.identity);

                // Aplica las texturas a los muros y pisos
                ApplyTextures(room);

                // A�ade l�gica adicional seg�n sea necesario, como la conexi�n de salas
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
