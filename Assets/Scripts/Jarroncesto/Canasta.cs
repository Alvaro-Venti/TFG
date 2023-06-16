using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Canasta : MonoBehaviour
{
    public BasketManager bm;
    public int valor;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Bola"))
        {
            bm.CanastaHecha(valor);
            bm.Reponer();
        }
    }
}
