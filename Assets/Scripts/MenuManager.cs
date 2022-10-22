using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void BtnStart()
    {
        SceneManager.LoadScene("Inicio");
    }

    // Update is called once per frame
    public void BtnQuit()
    {
        Debug.Log("Adios");
        Application.Quit();
    }
}
