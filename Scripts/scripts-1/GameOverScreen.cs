using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
  
    public void Setup(GameObject go, GameObject points)
    {

        gameObject.SetActive(true);
        go.SetActive(false);
        points.SetActive(false);
    }

    public void ResartButton()
    {
        SceneManager.LoadScene("Arcade_game");

    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Main_Scene");
    }
}
