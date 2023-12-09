using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    Transform Player;

    [SerializeField]
    Vector3 offset = new(7, 10, 0);

    [SerializeField]
    float cameraSpeed = 10f;

    void LateUpdate()
    {
        transform.position = Player.position + offset;
    }
}
