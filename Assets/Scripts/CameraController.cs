using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    
    private void FixedUpdate()
    {
        MoveCamera();
    }

    private void MoveCamera() 
    {
        //Sigue al jugador
        Vector3 position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        transform.position = position;
    }

}
