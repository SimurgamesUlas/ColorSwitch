using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Ball;
   
    void Update()
    {
        if(Ball.position.y > transform.position.y){
            transform.position = new Vector3(
                transform.position.x,
                Ball.position.y,
                transform.position.z
                );
        }
    }
}
