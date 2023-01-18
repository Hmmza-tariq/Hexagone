using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track_01 : MonoBehaviour
{
    [SerializeField] GameObject[] go;
    int i = 0;
    [SerializeField]  float speed = 5f;

    void Update()
    {
        if (Vector3.Distance(transform.position, go[i].transform.position) < .1f)
        {
            i++;
            if(i >= go.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, go[i].transform.position,speed*Time.deltaTime);
    }

}

