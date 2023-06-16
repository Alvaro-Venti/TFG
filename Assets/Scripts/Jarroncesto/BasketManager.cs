using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.XR.Interaction.Toolkit;

public class BasketManager : MonoBehaviour
{
    public TMP_Text marcador;
    public TMP_Text contador;
    public int puntos;
    public GameObject bola;
    //public XRSocketInteractor socket_bola;
    public Transform respawn;
    public PlayableDirector timeline;
    
    private float tiempo;
    private bool apagado;
    void Start()
    {
        ReiniciarMarcador();
        puntos = -1;
        tiempo = 0f;
        apagado = true;
        //Empezar();
    }

    private void Update()
    {
        if (apagado)
            return;
        float cuenta = Mathf.FloorToInt(tiempo - Time.unscaledTime);
        if (cuenta > 0)
            contador.text = "" + cuenta;
        else
            FinJuego();
    }

    private void FinJuego()
    {
        timeline.Pause();
        ReiniciarTiempo();
        apagado = true;
        Reponer();
    }

    public void CanastaHecha(int bola)
    {
        puntos += bola;
        Debug.Log(puntos);
        marcador.text = "" + puntos;
    }

    public void Empezar()//la idea es meter esto con control por voz
    {
        if (puntos<0)
        {
            timeline.Play();
        }
        else
        {
            ReiniciarMarcador();
            timeline.Resume();
        }
            
        ReiniciarTiempo();
        tiempo = Time.unscaledTime + 60f;
        Reponer();
        apagado = false;
    }

    public void Reponer()//mucha duda de como hacer que funcione el reponer de la bola con un socket
    {
        bola.transform.position = respawn.position;
        //socket_bola.startingSelectedInteractable = go.GetComponent<XRGrabInteractable>();
    }

    public void ReiniciarMarcador()
    {
        puntos = 0;
        marcador.text = "" + puntos;
    }

    public void ReiniciarTiempo()
    {
        tiempo = 0f;
        contador.text = "" + puntos;
    }

    public void BotonJuego()
    {
        if (apagado)
            Empezar();
        else
            FinJuego();
    }
}
