using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarPanel : MonoBehaviour
{
    public GameObject holograma;
    public Animation anim;

    private void OnTriggerEnter(Collider other)
    {
        holograma.SetActive(true);
        anim.Play();
    }
}
