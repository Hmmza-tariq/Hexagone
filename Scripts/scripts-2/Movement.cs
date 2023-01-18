using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public Rigidbody floor;
    public float Speed = 20f;
    public TextMeshProUGUI speedometer;
    public float collisionDamping = .5f;
    public float slowDuration = 3f;
    private Vector3 originalVelocity;
    private float timeStamp;
    public AudioSource engineSound;
    public Score sc;
    public int Level;
    public TextMeshProUGUI LevelTxt;
    public GameObject lvl_1;
    public GameObject lvl_2;
    public GameObject lvl_3;
    public GameObject Level1lastCar;
    public GameObject Level2lastCar;
    public GameObject Level3lastCar;
    private Vector3 initialPosition;
    public GameObject GOscreen;
    public TextMeshProUGUI FinalScore;
    public GameObject Winscreen;
    public TextMeshProUGUI WinScore;
    public GameObject NextLevelTxt;
    public TextMeshProUGUI countdown;
    private float countdownTimer = 4.0f;
    public GameObject StreetLamps;
    public GameObject trees;
    public GameObject Sun;
    public GameObject headLights;
    public Light[] SunLight;
    private Boolean Left, Right;
    public GameObject contols;
    public GameObject pts;
    void Start()
    {
        pts.SetActive(true);
        Left = false;
        Right = false;
        Level = 1;
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        Time.timeScale = 1;
        StreetLamps.SetActive(false);
        trees.SetActive(false);
        headLights.SetActive(false);
        Sun.SetActive(true);
        engineSound.Play();
    }

    private void Update()
    {
        

        LevelTxt.text = "Level: " + Level;
        if (Level == 1)
        {
            lvl_2.SetActive(false);
            lvl_3.SetActive(false);
            if (Level1lastCar.transform.position.z < rb.transform.position.z)
            {
                nextLevel();
            }
        }
        else if(Level == 2)
        {
            trees.SetActive(true);
            SunLight[0].intensity = 0.7f;
            SunLight[1].intensity = 0.7f;
            headLights.SetActive(true);           
            lvl_2.SetActive(true);
            if (Level2lastCar.transform.position.z < rb.transform.position.z)
            {
                nextLevel();
            }
        }
        else if(Level == 3)
        {
            StreetLamps.SetActive(true);
            Sun.SetActive(false);
            lvl_3.SetActive(true);
            if (Level3lastCar.transform.position.z < rb.transform.position.z)
            {
                nextLevel();
            }
        }


        if (timeStamp < Time.time)
        {
            rb.velocity = originalVelocity;
            timeStamp = Mathf.Infinity;
        }

        if (rb.transform.position.y < floor.transform.position.y || sc.score < 1)
        {
            sc.score = 0;
            end_game();
        }

        speedometer.text = "Speed: " + Speed + " Km/h";
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3( 0, 0, 5) * Time.deltaTime * Speed;
        if (Left)
        {
            transform.position += Vector3.left * 15 * Time.deltaTime;
        }
        if (Right)
        {
            transform.position += Vector3.right * 15 * Time.deltaTime;
        }

    }
    public void MoveLeft()
    {
        Left = true; ;

    }


    public void MoveRight()
    {
        Right = true;

    }

    public void stopMoving()
    {
        Left = false;
        Right = false;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("obstacle"))
        {
            Destroy(collision.gameObject);

            sc.score -= 10;
            Speed *= collisionDamping;
            Invoke("ResetVelocity", slowDuration);

        }
    }

        void ResetVelocity()
        {
        Speed = Speed / collisionDamping;
        }
   

    private void nextLevel()
    {
        if(Level == 1)
        {
            Speed = 23f;
        }else if(Level == 2) {
            Speed = 27f;
        }
        if (Level == 3)
        {
        win();
        }
        else
        {
            pts.SetActive(false);

            NextLevelTxt.SetActive(true);

        countdownTimer -= Time.deltaTime;
        if (countdownTimer > 0)
        {
            countdown.text = countdownTimer.ToString("0");
        }
        else if (countdownTimer <= 0 && countdownTimer > -1)
        {
            countdown.text = "GO!";

            }
            else
        {
            countdown.text = "";
            NextLevelTxt.SetActive(false);
            Level++;
            transform.position = initialPosition;
                pts.SetActive(true);
                countdownTimer = 4.0f;
        }
        }
      
    }

    

    private void end_game()
    {
        pts.SetActive(false);
        contols.SetActive(false);
        FinalScore.text = "Your Score: " + sc.score;
        Time.timeScale = 0;
        GOscreen.SetActive(true);
    }

    private void win()
    {
        pts.SetActive(false);
        contols.SetActive(false);
        NextLevelTxt.SetActive(false);
        WinScore.text = "Your Score: " + sc.score;
        Time.timeScale = 0;
        Winscreen.SetActive(true);
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("Car_Game");
    }
    public void quit()
    {
        SceneManager.LoadScene("Main_Scene");
    }
}


