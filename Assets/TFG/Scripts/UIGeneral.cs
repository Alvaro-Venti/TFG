using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGeneral : MonoBehaviour
{
    public GameObject ContLum;
    public GameObject ContAmb;

    public void Swap (GameObject x)
    {
        if (x.activeSelf)
            x.SetActive(false);
        else
            x.SetActive(true);
    }
}
