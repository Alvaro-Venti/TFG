using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public BasketManager bm;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Bola"))
        {
            bm.Reponer();
        }
    }
}
