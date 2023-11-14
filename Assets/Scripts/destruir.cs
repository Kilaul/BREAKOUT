using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir : MonoBehaviour
{
    public string tagColision = "ball";
    public string tagColision1 = "BALL1";
    public GameObject powerup1;
    public GameObject powerup2;
    public GameObject powerup3;
    public List<GameObject> drop;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        float randomvalue = Random.Range(1,20);
        
        if (collision.tag == tagColision)
        {
            Destroy(gameObject);

            if(randomvalue == 1)
            {
                Instantiate(powerup1, transform.position, transform.rotation);

            }

        }
        if (collision.tag == tagColision1)
        {
            Destroy(gameObject);
            if(randomvalue == 1)
            {
                Instantiate(powerup1, transform.position, transform.rotation);
            }
       

        }

        if (collision.tag == tagColision)
        {
            Destroy(gameObject);

            if (randomvalue == 3)
            {
                Instantiate(powerup1, transform.position, transform.rotation);

            }

        }
        if (collision.tag == tagColision1)
        {
            Destroy(gameObject);
            if (randomvalue == 3)
            {
                Instantiate(powerup1, transform.position, transform.rotation);
            }


        }

        if (collision.tag == tagColision)
        {
            Destroy(gameObject);

            if (randomvalue == 2)
            {
                Instantiate(powerup1, transform.position, transform.rotation);

            }

        }
        if (collision.tag == tagColision1)
        {
            Destroy(gameObject);
            if (randomvalue == 2)
            {
                Instantiate(powerup1, transform.position, transform.rotation);
            }


        }

        if (collision.tag == tagColision)
        {
            Destroy(gameObject);

            if (randomvalue == 4)
            {
                Instantiate(powerup2, transform.position, transform.rotation);

            }

        }
        if (collision.tag == tagColision1)
        {
            Destroy(gameObject);
            if (randomvalue == 4)
            {
                Instantiate(powerup2, transform.position, transform.rotation);
            }


        }

        if (collision.tag == tagColision)
        {
            Destroy(gameObject);

            if (randomvalue == 5)
            {
                Instantiate(powerup3, transform.position, transform.rotation);

            }

        }
        if (collision.tag == tagColision1)
        {
            Destroy(gameObject);
            if (randomvalue == 5)
            {
                Instantiate(powerup3, transform.position, transform.rotation);
            }


        }
    }
}
