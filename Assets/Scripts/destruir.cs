using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir : MonoBehaviour
{
    public string tagColision = "ball";
    public string tagColision1 = "BALL1";
    public GameObject powerup1;
    public List<GameObject> drop;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tagColision)
        {
            Destroy(gameObject);
            Instantiate(powerup1, transform.position, transform.rotation);

        }
        if (collision.tag == tagColision1)
        {
            Destroy(gameObject);
            Instantiate(powerup1, transform.position, transform.rotation);

        }
    }
}
