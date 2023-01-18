using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainToArcade : MonoBehaviour
{
    public GameObject arcade;
    public GameObject car;
    public GameObject shooter;
  
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            arcade.SetActive(true);
            car.SetActive(true);
            shooter.SetActive(true);
           
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            arcade.SetActive(false);
            car.SetActive(false);
            shooter.SetActive(false);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            arcade.SetActive(true);
            car.SetActive(true);
            shooter.SetActive(true);
           
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        {
            if (collision.gameObject.tag == "Player")
            {
                arcade.SetActive(false);
                car.SetActive(false);
                shooter.SetActive(false);
            }
        }

    }
}