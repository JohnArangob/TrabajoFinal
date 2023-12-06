using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 offser;
    public float cameraSpeed = 10f;
    

    void LateUpdate()
    {

        transform.position = Player.position + offser;
       
    }
}

