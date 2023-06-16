using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public List<GameObject> listaCamaras = new List<GameObject>();
    private int indice = 0;
    // Start is called before the first frame update

    public void siguiente()
    {
         if(indice == listaCamaras.Count - 1)
        {
            indice = 0;
        }
        else
        {
            indice++;
        }
        
        for(int i=0; i<listaCamaras.Count; i++)
        {
            if(i == indice)
                listaCamaras[i].SetActive(true);
            else
                listaCamaras[i].SetActive(false);
        }
    }

    // Update is called once per frame
    public  void anterior()
    {
        if(indice == 0)
        {
            indice = listaCamaras.Count - 1;
        }
        else
        {
            indice--;
        }

        for(int i=0; i<listaCamaras.Count; i++)
        {
            if(i == indice)
                listaCamaras[i].SetActive(true);
            else
                listaCamaras[i].SetActive(false);
        }
    }
}
