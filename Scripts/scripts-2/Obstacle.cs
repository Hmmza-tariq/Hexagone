using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        rb.velocity = Vector3.forward*Random.Range(1,8);
    }
}
