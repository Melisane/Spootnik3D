using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {


    // First Mode
    public void Menu()
    {

        SceneManager.LoadScene("Menu", LoadSceneMode.Single);

    }


    // First Mode
    public void PlayGame () {

        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }



    // Quit Game
    public void QuitGame()
    {

        Application.Quit();
        Debug.Log("Quit Game");

    }


}
