using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuprincipalhard : MonoBehaviour
{
    // Start is called before the first frame update
    public void PLAY()
    {
        Debug.Log("PLAY");
        SceneManager.LoadScene("hardplay");

    }

}
