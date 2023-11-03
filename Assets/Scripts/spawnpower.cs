using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawnpower : MonoBehaviour
{
    public GameObject AMARILLO;
    public GameObject powerup1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == AMARILLO)
        {
           
           Instantiate(powerup1, AMARILLO.transform.position, AMARILLO.transform.rotation);
        }
    }
}
