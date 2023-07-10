using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenInfoAparcamientos : MonoBehaviour
{
    [SerializeField] private string url;
    [SerializeField] private GameObject total;
    [SerializeField] private GameObject habitants;
    [SerializeField] private GameObject liures;

    [SerializeField] private Transform pos;

    private DataAparcamientos data;

    // Start is called before the first frame update
    void Start()
    {
        HTTPRequest.ConectaUrl(url, (string error) =>
        {
            // Error
            Debug.Log("Error: " + error);
        }, (string text) =>
        {
            // Successfully contacted URL
            Debug.Log("Success: " + text);
            data = DataAparcamientos.LoadData(text);
            Debug.Log(data.total);

            GameObject go = Instantiate(total, pos);
            go.transform.localScale = new Vector3(1, (data.total / 1000f), 1);

            go = Instantiate(habitants, pos);
            go.transform.localScale = new Vector3(1, (data.habitants / 1000f), 1);
            go.transform.position = go.transform.position + new Vector3(0.09f, 0, 0);

            go = Instantiate(liures, pos);
            go.transform.localScale = new Vector3(1, (data.lliures / 1000f), 1);
            go.transform.position = go.transform.position + new Vector3(-0.09f, 0, 0);
            Debug.Log(go.transform.localScale);
        });
    }
}
