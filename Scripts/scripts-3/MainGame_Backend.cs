using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGame_Backend : MonoBehaviour
{
    public AudioSource[] sounds;
    public void MainToShooter()
    {
        SceneManager.LoadScene("shooter_game");
        sounds[2].Play();
    }

    public void MainToArcade()
    {
        SceneManager.LoadScene("Arcade_game");
        sounds[0].Play();
    } public void MainToCar()
    {
        SceneManager.LoadScene("Car_Game");
        sounds[1].Play();
    }
}
