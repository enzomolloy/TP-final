using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObg : MonoBehaviour
{ 
public float speed;
public bool toRight;

public GameObject baseDerecha;
public GameObject baseIzq;

void Start()
{
    toRight = true;
}

void Update()
{
    if (toRight == true)
    {
        transform.position += new Vector3(0, 0, speed);
    }
    else
    {
        transform.position -= new Vector3(0, 0, speed);
    }

    if (transform.position.z > baseDerecha.transform.position.z - 1)
    {
        toRight = false;
    }
    if (transform.position.z < baseIzq.transform.position.z + 1)
    {
        toRight = true;
    }

}
}
