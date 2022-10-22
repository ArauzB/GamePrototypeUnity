using UnityEngine;
using UnityEngine.SceneManagement;



public class ReturnMenu : MonoBehaviour



{


    // Start is called before the first frame update
    public void Btn_MenuInicio()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    public void Btn_Quit()
    {
        Debug.Log("Adios");
        Application.Quit();
    }



}


