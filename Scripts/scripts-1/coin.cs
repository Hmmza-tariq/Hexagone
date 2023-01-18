using UnityEngine;

public class coin : MonoBehaviour
{
    // The amplitude of the oscillation
    public float amplitude = .5f;

    // The frequency of the oscillation
    public float frequency = 1f;

    // The initial height of the object
    private float startHeight;

    // The audio source to play the audio clip
    public AudioSource collectSound;

    // OnTriggerEnter is called when the object enters a trigger collider
    // Start is called before the first frame update
    void Start()
    {
        // Save the initial height of the object
        startHeight = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the oscillation using a sinusoidal function
        float oscillation = amplitude * Mathf.Sin(frequency * Time.time);

        // Set the position of the object to its initial height plus the oscillation
        transform.position = new Vector3(transform.position.x, startHeight + oscillation, transform.position.z);
    }
    void OnCollisionEnter(Collision c)
    {
        // Check if the player collided with the coin
        if (c.gameObject.tag == "Player")
        {
            Debug.Log("coin_collected");
            GetComponent<Rigidbody>().AddForce(0, 100, 0);

            score.instance.AddPoints();

            collectSound.Play();
            // Destroy the coin game object
            Destroy(gameObject);
            // Play the collect sound
        }
    }
}

