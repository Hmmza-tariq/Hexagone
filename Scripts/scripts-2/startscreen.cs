using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startscreen : MonoBehaviour
{
    public GameObject settings;
    public GameObject backB;
    public GameObject pause;
    public GameObject[] hide;
    public AudioSource st;

    public void contols()
    {
        settings.SetActive(true);
        backB.SetActive(true);
    }

    public void back()
    {
        settings.SetActive(false);
        backB.SetActive(false);

    }
    public void quit()
    {
        SceneManager.LoadScene("Main_Scene");
    }
    public void play()
    {
        for (int i = 0; i < hide.Length; i++)
        {
            hide[i].SetActive(true);
        }
        pause.SetActive(false);
        st.Play();
        Time.timeScale = 1.0f;
        
    }

}
