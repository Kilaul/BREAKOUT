using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup1 : MonoBehaviour
{
    public string rojo = "powerup1";
    public string verde = "powerup2";
    public GameObject BALL1;
    public GameObject POW;
    public Marcador punt;
    public Vector2 direcci�n;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == rojo)

        {



            Destroy(POW);
            Instantiate(BALL1, transform.position, transform.rotation);
                punt.puntuaci�nA += 1;
               

         











        }
        if (collision.tag == verde)

        {



            Destroy(POW);
            Instantiate(BALL1, transform.position, transform.rotation);
            direcci�n = new Vector2(0, 1);

            Instantiate(BALL1, transform.position, transform.rotation);
            direcci�n = new Vector2(1, 1);

            Instantiate(BALL1, transform.position, transform.rotation);
            direcci�n = new Vector2(0, -1);













        }
    }
}
