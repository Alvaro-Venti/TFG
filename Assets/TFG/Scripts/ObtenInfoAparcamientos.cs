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
            Debug.Log("Success");
            data = DataAparcamientos.LoadData(text);

            GameObject go = Instantiate(total, pos);
            float aux = data.total / 1000f;
            go.transform.localScale = new Vector3(1, aux, 1);
            go.transform.localPosition = go.transform.localPosition + new Vector3(0, aux/2f, 0);

            go = Instantiate(habitants, pos);
            aux = data.habitants / 1000f;
            go.transform.localScale = new Vector3(1, aux, 1);
            go.transform.localPosition = go.transform.localPosition + new Vector3(0.7f, aux/2f, 0);

            go = Instantiate(liures, pos);
            aux = data.lliures / 1000f;
            go.transform.localScale = new Vector3(1, aux, 1);
            go.transform.localPosition = go.transform.localPosition + new Vector3(-0.7f, aux/2f, 0);
        });
    }
}
