using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky : MonoBehaviour
{
private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.transform.SetParent(null);
        }
    }
}
