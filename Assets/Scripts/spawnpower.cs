using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawnpower : MonoBehaviour
{
    public GameObject AMARILLO;
    public GameObject powerup1;
    public GameObject powerup2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == AMARILLO)
        {
            float randomvalue = Random.Range(1,2);
            if (randomvalue == 1)
            {

                Instantiate(powerup1, AMARILLO.transform.position, AMARILLO.transform.rotation);


            }
            if (randomvalue == 2)
            {

                Instantiate(powerup2, AMARILLO.transform.position, AMARILLO.transform.rotation);



            }
        }
    }
}

