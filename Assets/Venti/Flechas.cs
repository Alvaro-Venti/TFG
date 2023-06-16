using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flechas : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Escudo"))
        {
            other.GetComponent<Animator>().enabled = false;
            
        }

        rb.isKinematic = true;
    }

    void OnCollisionEnter(Collision other)
    {
        rb.isKinematic = true;
    }
}
