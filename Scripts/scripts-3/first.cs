using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class first : MonoBehaviour
{
    public GameObject loading;
    public GameObject About;
    public GameObject back;
    public AudioSource bgS;
    public GameObject[] hide;
    public void gameSt()
    {
        loading.SetActive(true);
        bgS.Play();
        Invoke("pl",3);
    }public void pl()
    {
        SceneManager.LoadScene("Main_Scene");
    }

    public void about()
    {
        for(int i = 0; i < hide.Length; i++)
        {
            hide[i].SetActive(false);
        }
        About.SetActive(true);
        back.SetActive(true);

    }public void quit()
    {
        Application.Quit();
    }
    public void BACK()
    {
        for (int i = 0; i < hide.Length; i++)
        {
            hide[i].SetActive(true);
        }
        About.SetActive(false);
        back.SetActive(false);
    }
}
