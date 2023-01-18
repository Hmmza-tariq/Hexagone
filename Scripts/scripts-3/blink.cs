using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{
    float interval;
    bool lightOn;
    public AudioSource soundEffect;

    void Start()
    {
        soundEffect = GetComponent<AudioSource>();
        interval = Random.Range(0.5f, 5f);
        lightOn = true;
    }

    void Update()
    {
        interval -= Time.deltaTime;
        if (interval <= 0f)
        {
            lightOn = !lightOn;
            GetComponent<Light>().enabled = lightOn;
            if (lightOn)
            {
                soundEffect.Play();
            }
            interval = Random.Range(0.5f, 5f);
        }
    }
}
