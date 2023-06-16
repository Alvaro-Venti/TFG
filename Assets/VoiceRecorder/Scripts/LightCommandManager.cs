using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCommandManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void encender()
    {
        GetComponent<Light>().enabled = true;
    }

    // Update is called once per frame
    public  void apagar()
    {
        GetComponent<Light>().enabled = false;
    }
    
}
