using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    private MeshRenderer[] mesh;
    public bool apagar = false;
    void Start()
    {
        mesh = GetComponentsInChildren<MeshRenderer>();
    }

    /*private void Update() 
    {
        if(apagar)
        {
            ToggleVisibility();
            apagar = false;
        }
        
    }*/

    public void ToggleVisibility()
    {
        mesh = GetComponentsInChildren<MeshRenderer>();
        foreach(MeshRenderer x in mesh)
        {
            x.enabled = !x.enabled;
        }
    }
}
