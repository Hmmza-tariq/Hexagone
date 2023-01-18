using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    public GameObject controls;
    public GameObject pt;
    public GameOverScreen gos;
    public AudioSource GOsound;
    public AudioSource GameSound;
    [SerializeField] GameObject[] go;
    int i = 0;
    [SerializeField] float speed = 20f;

    void Update()
    {
        if (Vector3.Distance(transform.position, go[i].transform.position) < .1f)
        {
            i++;
            if (i >= go.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, go[i].transform.position, speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision c)
    {
  
        if (c.gameObject.tag == "Player")
        {
            GameSound.Stop();
            GOsound.Play();
            gos.Setup(controls,pt);
        }
    }

}
