using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCommander : MonoBehaviour
{
    // Start is called before the first frame update
    public void abrir()
    {
        transform.localEulerAngles = new Vector3(0,90,0);
    }

    // Update is called once per frame
    public  void cerrar()
    {
        transform.localEulerAngles = new Vector3(0,0,0);
    }
}
