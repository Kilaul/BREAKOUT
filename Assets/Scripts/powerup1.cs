using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup1 : MonoBehaviour
{
    public string tagColision = "powerup1";
    public GameObject BALL1;
    public Marcador punt;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tagColision)

        {
          
      
            
                Instantiate(BALL1, transform.position, transform.rotation);
                punt.puntuaciónA += 1;

          
               
         
       
            
               
       
            



        }
        
    }
}
