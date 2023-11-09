using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BallMovement : MonoBehaviour
{
    public float velocity;
    public Vector2 dirección;
    public string tagColision = "destruir";
    public Marcador punt;
    public Score puntB;
    public bool SPAWN;
    void Update()
    {

        transform.position = transform.position + (Vector3)dirección * velocity * Time.deltaTime; 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.gameObject.tag == "verticalA")
        {
            dirección = new Vector2(-dirección.x, dirección.y);
        }
        if (collision.gameObject.tag == "verticalB")
        {
            dirección = new Vector2(dirección.x, -dirección.y);
        }

        if (collision.gameObject.tag == "PALA")
        {
            dirección = new Vector2(-dirección.x, -dirección.y);
            float y = Random.Range(0f, 1f); //le ponemos "f" porque sin ella funciona de otra forma.
            if (y > 0)
            {
                y = 1;
            }
            else
            {
                y = -1;
            }
            float x = Random.Range(-1f,-0.1f);
            dirección = new Vector2(x, y);
        }
        if (collision.gameObject.tag == "PALA DERECHA")
        {
            dirección = new Vector2(0, 0);
            float y = Random.Range(0f, 1f); //le ponemos "f" porque sin ella funciona de otra forma.
            if (y > 0)
            {
                y = 1;
            }
            else
            {
                y = -1;
            }
            float x = Random.Range(0.1f, 1f);
            dirección = new Vector2(x, y);
        }
        if (collision.gameObject.tag == "PALA CENTRO")
        {
            dirección = new Vector2(0, 1);
        }
        if (collision.gameObject.tag == "horizontal")
        {
            dirección = new Vector2(dirección.x, -dirección.y);
        }
        if (collision.gameObject.tag == "destruir")
        {
            dirección = new Vector2(dirección.x, -dirección.y);
            puntB.puntuaciónB += 1;
        }
        if (collision.gameObject.tag == "destruir2")
        {
            dirección = new Vector2(dirección.x, -dirección.y);
            puntB.puntuaciónB += 2;
        }
        if (collision.gameObject.tag == "destruir_rojos")
        {
            dirección = new Vector2(dirección.x, -dirección.y);
            puntB.puntuaciónB += 5;
        }
        if (collision.gameObject.tag == "destruir_rojos2")
        {
            dirección = new Vector2(dirección.x, -dirección.y);
            puntB.puntuaciónB += 6;
        }
        if (collision.gameObject.tag == "destruir_naranjas")
        {
            dirección = new Vector2(dirección.x, -dirección.y);
            puntB.puntuaciónB += 3;
        }
        if (collision.gameObject.tag == "destruir_naranjas2")
        {
            dirección = new Vector2(dirección.x, -dirección.y);
            puntB.puntuaciónB += 4;
        }
        if (collision.gameObject.tag == "vacio")
        {
            
            punt.puntuaciónA -= 1; //también está ++ o = punt.puntuación + 1

            if (SPAWN)
              { 
                Spawn(); 
            }
            
           else
            {
                Dissapear();
            }


        }


        void Spawn()
        {
            transform.position = new Vector3(0, 0, 0);
            float y = Random.Range(-1f, 0); //le ponemos "f" porque sin ella funciona de otra forma.
            if (y > 0)
            {
                y = 1;
            }
            else
            {
                y = -1;
            }
            float x = Random.Range(-1f, 1f);
            dirección = new Vector2(x, y);
        }
           
        void Dissapear()
        {
            float y = Random.Range(-1f, 0); //le ponemos "f" porque sin ella funciona de otra forma.
            if (y > 0)
            {
                y = 1;
            }
            else
            {
                y = -1;
                Destroy(gameObject);
            }
            
        }
    }
}
 