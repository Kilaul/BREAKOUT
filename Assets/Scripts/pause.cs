using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public void Pausa()
    {

        Time.timeScale = 0f;
        
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
    }
}
 
