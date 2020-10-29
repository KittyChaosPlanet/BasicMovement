using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomRotate : MonoBehaviour
{
public float speed = 10f;

    void Example()
    {
        
    }
    void Update()
    {
         transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
