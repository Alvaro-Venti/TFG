using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotInicio : MonoBehaviour
{
    public BasketManager bm;

    private Animator anim;
    private AudioSource audioSrc;

    private void Start()
    {
        audioSrc = this.GetComponent<AudioSource>();
        anim = this.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Mano"))
        {
            Pulsado();
        }
    }


    public void Pulsado()
    {
        StartCoroutine(CambiarEstado());
        audioSrc.Play();
        bm.BotonJuego();
    }

    IEnumerator CambiarEstado()
    {
        anim.SetBool("pulsado",false);
        yield return new WaitForSeconds(0.1f);
        anim.SetBool("pulsado",true);
    }
}
