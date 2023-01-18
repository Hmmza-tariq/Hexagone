using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject controlsUi;
    public settings set;
    public void quit()
    {
        if(SceneManager.GetActiveScene().name == "Arcade_game")
        {
            SceneManager.LoadScene("Main_scene");
        }else
            Application.Quit();
    }

    public void setting()
    {
        controlsUi.SetActive(true);
    }

    public void resume()
    {
        set.resume();
    }
}
