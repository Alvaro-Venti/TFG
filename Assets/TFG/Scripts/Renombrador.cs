using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Renombrador : MonoBehaviour
{
    public TextMeshProUGUI titulo;

    public void CambiaTitulo(string t)
    {
        titulo.text = t;
    }

}
