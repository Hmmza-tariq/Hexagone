using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject PauseUI;
    public GameObject controls;
    public AudioSource GameSound;
    public GameObject controlsUi;

    public void Start()
    {
        PauseUI.SetActive(false);
    }
    public void stop()
    {
        if (isPaused)
        {
            resume();
        }
        else
        {
            pause();
        }
    }
    public void pause()
    {
        controlsUi.SetActive(false);
        GameSound.Pause();
        PauseUI.SetActive(true);
        controls.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void resume()
    {
        controlsUi.SetActive(false);
        GameSound.Play();
        PauseUI.SetActive(false);
        controls.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
