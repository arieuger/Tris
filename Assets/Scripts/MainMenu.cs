using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("GameMode", 0);
    }

    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("GameMode", 1);
    }

    //Opcional pero está aquí por si o queredes usar
    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
