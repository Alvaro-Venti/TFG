using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataAparcamientos
{
    public int total;
    public int ora;
    public int habitants;
    public string barri;
    public int lliures;
    public string distrite;
    public int guals;
    public int solars;
    public int parquings;
    public float places_habitants;
    public string grup;
    public string altres;

    public static DataAparcamientos LoadData(string jsonData)
    {
        DataAparcamientos x = (DataAparcamientos)JsonUtility.FromJson<DataAparcamientos>(jsonData);
        return x;
    }

    private void Print(DataAparcamientos x) {
        Debug.Log("total " + x.total);
        Debug.Log("ora " + x.ora);
        Debug.Log("habitants " + x.habitants);
        Debug.Log("barri " + x.barri);
        Debug.Log("lliures " + x.lliures);
        Debug.Log("distrite " + x.distrite);
        Debug.Log("guals " + x.guals);
        Debug.Log("solars " + x.solars);
        Debug.Log("parquings " + x.parquings);
        Debug.Log("places_habitants " + x.places_habitants);
        Debug.Log("grup " + x.grup);
        Debug.Log("altres " + x.altres);
    }


}
