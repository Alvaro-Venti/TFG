using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResaltarColor : MonoBehaviour
{
    public Color color;

    private TMP_Text text;

    void Start()
    {
        text = this.GetComponent<TMP_Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        text.color = Color.magenta;
    }

    private void OnTriggerExit(Collider other)
    {
        text.color = color;
    }
}
