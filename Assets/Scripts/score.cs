using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int puntuaci�nB;
    public TMP_Text puntuaci�nBtexto;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puntuaci�nBtexto.text = puntuaci�nB.ToString(); //tostring es para transformarlo
        if (puntuaci�nB > 159) // alt gr + 1 = |, es o esto o lo otro
        {
            SceneManager.LoadScene("end");
        }
    }

}
