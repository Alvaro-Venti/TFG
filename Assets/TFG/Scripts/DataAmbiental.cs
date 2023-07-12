using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataAmbiental
{
    public float so2;
    public float no2;
    public float pm10;
    public string direccion;
    public string fecha_carga;
    public string calidad_ambiental;
    public int objectid;
    

    public static DataAmbiental LoadData(string jsonData)
    {
        jsonData += "}";
        DataAmbiental x = (DataAmbiental)JsonUtility.FromJson<DataAmbiental>(jsonData);

        return x;
    }

    private static void Print(DataAmbiental x)
    {
        Debug.Log("Campo 'so2': " + x.so2);
        Debug.Log("Campo 'no2': " + x.no2);
        Debug.Log("Campo 'pm10': " + x.pm10);
        Debug.Log("Campo 'direccion': " + x.direccion);
        Debug.Log("Campo 'fecha_carga': " + x.fecha_carga);
        Debug.Log("Campo 'calidad_ambiental': " + x.calidad_ambiental);
        Debug.Log("Campo 'objectid': " + x.objectid);
    }

}
