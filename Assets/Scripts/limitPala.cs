using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitPala : MonoBehaviour
{
    public float maxX;
    public float minX;
    void Update()
    {

        if (transform.position.x < maxX)
        {

            transform.position = new Vector3(maxX, transform.position.y, 0); //devuelve el palo al límite
        }
        if (transform.position.x > minX)
        {

            transform.position = new Vector3(minX, transform.position.y, 0); //devuelve el palo al límite
        }
    }
}
