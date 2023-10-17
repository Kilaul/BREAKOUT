using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int puntuaciónB;
    public TMP_Text puntuaciónBtexto;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puntuaciónBtexto.text = puntuaciónB.ToString(); //tostring es para transformarlo
        if (puntuaciónB > 159) // alt gr + 1 = |, es o esto o lo otro
        {
            SceneManager.LoadScene("end");
        }
    }

}
