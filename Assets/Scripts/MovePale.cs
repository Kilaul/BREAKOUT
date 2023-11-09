using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePale : MonoBehaviour
{
    public float velocity;
    
   


    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        {


            horizontal = Input.GetAxis("Horizontal");
            transform.position = transform.position + new Vector3(horizontal, 0, 0) * velocity * Time.deltaTime;
        }
        
    }
}
