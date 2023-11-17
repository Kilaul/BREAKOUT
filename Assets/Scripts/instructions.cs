using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class instructions : MonoBehaviour
{
    // Start is called before the first frame update
    public void INSTRUCCIONES()
    {
        Debug.Log("instrucciones");
        SceneManager.LoadScene("instrucciones");
    }
    }
