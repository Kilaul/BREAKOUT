using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir : MonoBehaviour
{
    public string tagColision = "ball";

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tagColision)
        {
            Destroy(gameObject);



        }
    }
}
