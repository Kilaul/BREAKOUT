using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirPOW : MonoBehaviour
{
    public string pala1 = "PALA";
    public string pala2 = "PALA DERECHA";
    public string pala = "PALA CENTRO";
    public GameObject powerup1;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == pala1)
        {
            Destroy(gameObject);
            Instantiate(powerup1, transform.position, transform.rotation);

        }
        if (collision.tag == pala2)
        {
            Destroy(gameObject);
            Instantiate(powerup1, transform.position, transform.rotation);

        }
        if (collision.tag == pala)
        {
            Destroy(gameObject);
            Instantiate(powerup1, transform.position, transform.rotation);

        }
    }
}