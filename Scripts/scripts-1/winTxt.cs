using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTxt : MonoBehaviour
{
    public GameOverScreen gos;
    public GameObject controls;
    public GameObject pt;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gos.Setup(controls,pt);
        }
    }
}
