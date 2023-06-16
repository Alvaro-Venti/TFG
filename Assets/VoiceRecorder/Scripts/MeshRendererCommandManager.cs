using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererCommandManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void mostrar()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }

    // Update is called once per frame
    public  void ocultar()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
    
}
