using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //private enum { };

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bound"))
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
