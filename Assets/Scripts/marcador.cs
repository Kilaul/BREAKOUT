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
    public int puntuaci�nA;
    public TMP_Text puntuaci�nAtexto;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puntuaci�nAtexto.text = puntuaci�nA.ToString(); //tostring es para transformarlo


        if (puntuaci�nA < 1) // alt gr + 1 = |, es o esto o lo otro
        {
            SceneManager.LoadScene("menu");
        }
    }

}
