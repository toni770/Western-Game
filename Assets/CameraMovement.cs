using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public int stop;
    public float speed;
    int start = 0;

    void Update()
    {
        var step = speed * Time.deltaTime;
        start += 1;
        if(start <= stop)transform.Rotate(0, -step, 0); 
    }
}
