using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSound : MonoBehaviour
{
    // Start is called before the first frame update
    public static coinSound instance;
    // The audio clip to play when the coin is collected
    public AudioClip collectSound;

    // The audio source to play the audio clip
    public AudioSource audioSource;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision c)
    {
        // Check if the player collided with the coin
        if (c.gameObject.tag == "Player")
        {
            audioSource.enabled = true;
            audioSource.PlayOneShot(collectSound);
        }
    }
}
