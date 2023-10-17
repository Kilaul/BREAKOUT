using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Marcador : MonoBehaviour
{
    public int puntuaciónA;
    public TMP_Text puntuaciónAtexto;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puntuaciónAtexto.text = puntuaciónA.ToString(); //tostring es para transformarlo


        if (puntuaciónA < 1) // alt gr + 1 = |, es o esto o lo otro
        {
            SceneManager.LoadScene("menu");
        }
    }

}
