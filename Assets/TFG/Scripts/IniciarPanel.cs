using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarPanel : MonoBehaviour
{
    public GameObject holograma;
    public GameObject mapa;
    public Animation anim;

    private void OnTriggerEnter(Collider other)
    {
        holograma.SetActive(true);
        mapa.SetActive(true);
        anim.Play();
    }
}
