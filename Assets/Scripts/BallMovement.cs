using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BallMovement : MonoBehaviour
{
    public float velocity;
    public Vector2 direcci�n;
    public string tagColision = "destruir";

    void Update()
    {

        transform.position = transform.position + (Vector3)direcci�n * velocity * Time.deltaTime; 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.gameObject.tag == "verticalA")
        {
            direcci�n = new Vector2(-direcci�n.x, direcci�n.y);
        }
        if (collision.gameObject.tag == "verticalB")
        {
            direcci�n = new Vector2(direcci�n.x, -direcci�n.y);
        }
        if (collision.gameObject.tag == "PALA")
        {
            direcci�n = new Vector2(-direcci�n.x, -direcci�n.y);
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
            direcci�n = new Vector2(x, y);
        }
        if (collision.gameObject.tag == "PALA DERECHA")
        {
            direcci�n = new Vector2(0, 0);
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
            direcci�n = new Vector2(x, y);
        }
        if (collision.gameObject.tag == "PALA CENTRO")
        {
            direcci�n = new Vector2(0, 1);
        }
        if (collision.gameObject.tag == "horizontal")
        {
            direcci�n = new Vector2(direcci�n.x, -direcci�n.y);
        }
        if (collision.gameObject.tag == "destruir")
        {
            direcci�n = new Vector2(direcci�n.x, -direcci�n.y);
        }
        if (collision.gameObject.tag == "vacio")
        {
         
            Spawn();

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
            direcci�n = new Vector2(x, y);
        }
           
    }
}
 